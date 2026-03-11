using Datagsm.OpenApi.Clients;

namespace Datagsm.OpenApi;

/// <summary>
/// DataGSM OpenAPI 클라이언트.
/// <para>사용 후 반드시 <see cref="Dispose"/>를 호출하거나 <c>using</c> 블록 안에서 사용하세요.</para>
/// </summary>
/// <example>
/// <code>
/// using var client = new DataGsmClient("your-api-key");
/// var students = await client.Students.GetStudentsAsync(new StudentRequest { Grade = 2 });
/// </code>
/// </example>
public sealed class DataGsmClient : IDisposable
{
    private readonly HttpClient _httpClient;
    private bool _disposed;

    /// <summary>학생 데이터 API</summary>
    public StudentClient Students { get; }

    /// <summary>동아리 데이터 API</summary>
    public ClubClient Clubs { get; }

    /// <summary>프로젝트 데이터 API</summary>
    public ProjectClient Projects { get; }

    /// <summary>NEIS 급식/학사일정 API</summary>
    public NeisClient Neis { get; }

    /// <param name="apiKey">DataGSM 클라이언트 포털에서 발급받은 API 키.</param>
    public DataGsmClient(string apiKey) : this(new DataGsmClientOptions(apiKey)) { }

    /// <param name="options">클라이언트 설정 옵션.</param>
    public DataGsmClient(DataGsmClientOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);

        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(options.BaseUrl),
            Timeout = options.Timeout
        };
        _httpClient.DefaultRequestHeaders.Add("X-API-KEY", options.ApiKey);

        Students = new StudentClient(_httpClient);
        Clubs = new ClubClient(_httpClient);
        Projects = new ProjectClient(_httpClient);
        Neis = new NeisClient(_httpClient);
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        if (_disposed) return;
        _httpClient.Dispose();
        _disposed = true;
    }
}
