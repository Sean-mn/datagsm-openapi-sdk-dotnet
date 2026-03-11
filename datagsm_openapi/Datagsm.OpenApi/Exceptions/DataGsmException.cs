namespace Datagsm.OpenApi.Exceptions;

/// <summary>DataGSM API 예외 기본 클래스</summary>
public class DataGsmException : Exception
{
    public DataGsmException(string message) : base(message) { }
    public DataGsmException(string message, Exception innerException) : base(message, innerException) { }
}
