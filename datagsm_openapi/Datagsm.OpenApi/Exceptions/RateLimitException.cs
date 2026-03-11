namespace Datagsm.OpenApi.Exceptions;

/// <summary>요청 횟수 초과 (HTTP 429)</summary>
public sealed class RateLimitException : DataGsmException
{
    public RateLimitException(string message) : base(message) { }
}
