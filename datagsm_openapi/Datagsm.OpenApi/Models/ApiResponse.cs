namespace Datagsm.OpenApi.Models;

/// <summary>DataGSM API 공통 응답 래퍼</summary>
internal sealed class 
    ApiResponse<T>
{
    public string Status { get; init; } = string.Empty;
    public int Code { get; init; }
    public string Message { get; init; } = string.Empty;
    public T? Data { get; init; }
}
