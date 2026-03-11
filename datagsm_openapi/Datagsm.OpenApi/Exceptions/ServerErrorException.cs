namespace Datagsm.OpenApi.Exceptions;

/// <summary>서버 내부 오류 (HTTP 500)</summary>
public sealed class ServerErrorException : DataGsmException
{
    public ServerErrorException(string message) : base(message) { }
}
