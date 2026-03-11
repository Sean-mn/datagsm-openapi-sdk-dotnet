using System.Text.Json.Serialization;

namespace Datagsm.OpenApi.Models;

/// <summary>프로젝트 정렬 기준</summary>
public enum ProjectSortBy
{
    [JsonStringEnumMemberName("ID")] Id,
    [JsonStringEnumMemberName("NAME")] Name
}
