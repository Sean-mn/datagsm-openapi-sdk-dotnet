namespace Datagsm.OpenApi.Exceptions;

/// <summary>API 키가 유효하지 않거나 만료됨 (HTTP 401)</summary>
public sealed class UnauthorizedException : DataGsmException
{
    public UnauthorizedException(string message) : base(message) { }
}
