using System.Text.Json;
using System.Text.Json.Serialization;
using Datagsm.OpenApi.Exceptions;
using Datagsm.OpenApi.Models;

namespace Datagsm.OpenApi.Clients;

public abstract class BaseClient
{
    protected readonly HttpClient HttpClient;

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
        Converters = { new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseUpper) }
    };

    protected BaseClient(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    protected async Task<T> GetAsync<T>(
        string path,
        IEnumerable<(string Key, string? Value)> queryParams,
        CancellationToken cancellationToken)
    {
        var url = BuildUrl(path, queryParams);
        var response = await HttpClient.GetAsync(url, cancellationToken).ConfigureAwait(false);
        await EnsureSuccessAsync(response, cancellationToken).ConfigureAwait(false);

        var content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        var apiResponse = JsonSerializer.Deserialize<ApiResponse<T>>(content, JsonOptions)
            ?? throw new DataGsmException("응답을 역직렬화하는 데 실패했습니다.");

        return apiResponse.Data ?? throw new DataGsmException("응답 데이터가 null입니다.");
    }

    private static string BuildUrl(string path, IEnumerable<(string Key, string? Value)> queryParams)
    {
        var filtered = queryParams.Where(p => p.Value is not null).ToList();
        if (filtered.Count == 0) return path;

        var query = string.Join("&", filtered.Select(p =>
            $"{Uri.EscapeDataString(p.Key)}={Uri.EscapeDataString(p.Value!)}"));
        return $"{path}?{query}";
    }

    private static async Task EnsureSuccessAsync(HttpResponseMessage response, CancellationToken cancellationToken)
    {
        if (response.IsSuccessStatusCode) return;

        var content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        throw (int)response.StatusCode switch
        {
            400 => new BadRequestException(content),
            401 => new UnauthorizedException(content),
            403 => new ForbiddenException(content),
            429 => new RateLimitException(content),
            500 => new ServerErrorException(content),
            _ => new DataGsmException($"HTTP {(int)response.StatusCode}: {content}")
        };
    }

    /// <summary>enum 값을 API 쿼리 파라미터 문자열로 변환합니다.</summary>
    protected static string? ToApiString<T>(T? value) where T : struct, Enum
    {
        if (value is null) return null;

        return JsonNamingPolicy.SnakeCaseUpper.ConvertName(value.ToString()!);
    }
}
