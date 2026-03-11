namespace Datagsm.OpenApi.Exceptions;

/// <summary>잘못된 요청 파라미터 (HTTP 400)</summary>
public sealed class BadRequestException : DataGsmException
{
    public BadRequestException(string message) : base(message) { }
}
