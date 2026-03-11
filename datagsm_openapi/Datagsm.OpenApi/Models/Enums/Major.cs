using System.Text.Json.Serialization;

namespace Datagsm.OpenApi.Models;

/// <summary>전공</summary>
public enum Major
{
    [JsonStringEnumMemberName("SW_DEVELOPMENT")] SwDevelopment,
    [JsonStringEnumMemberName("SMART_IOT")] SmartIot,
    [JsonStringEnumMemberName("AI")] Ai
}
