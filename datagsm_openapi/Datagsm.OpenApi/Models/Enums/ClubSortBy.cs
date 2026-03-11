using System.Text.Json.Serialization;

namespace Datagsm.OpenApi.Models;

/// <summary>동아리 정렬 기준</summary>
public enum ClubSortBy
{
    [JsonStringEnumMemberName("ID")] Id,
    [JsonStringEnumMemberName("NAME")] Name,
    [JsonStringEnumMemberName("TYPE")] Type
}
