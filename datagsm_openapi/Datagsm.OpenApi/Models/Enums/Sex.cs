using System.Text.Json.Serialization;

namespace Datagsm.OpenApi.Models;

/// <summary>성별</summary>
public enum Sex
{
    [JsonStringEnumMemberName("MAN")] Man,
    [JsonStringEnumMemberName("WOMAN")] Woman
}
