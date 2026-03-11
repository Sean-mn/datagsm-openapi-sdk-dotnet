namespace Datagsm.OpenApi.Exceptions;

/// <summary>API 키에 필요한 권한 스코프가 없음 (HTTP 403)</summary>
public sealed class ForbiddenException : DataGsmException
{
    public ForbiddenException(string message) : base(message) { }
}
