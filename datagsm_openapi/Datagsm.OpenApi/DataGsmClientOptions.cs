namespace Datagsm.OpenApi;

/// <summary>DataGSM OpenAPI 클라이언트 설정 옵션</summary>
public sealed class DataGsmClientOptions
{
    /// <summary>API 키 (X-API-KEY 헤더로 전송). 30일마다 갱신 필요.</summary>
    public string ApiKey { get; }

    /// <summary>API Base URL. 기본값: https://openapi.data.hellogsm.kr</summary>
    public string BaseUrl { get; set; } = "https://openapi.data.hellogsm.kr";

    /// <summary>HTTP 요청 타임아웃. 기본값: 30초.</summary>
    public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(30);

    /// <param name="apiKey">DataGSM 클라이언트 포털에서 발급받은 API 키.</param>
    public DataGsmClientOptions(string apiKey)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(apiKey, nameof(apiKey));
        ApiKey = apiKey;
    }
}
