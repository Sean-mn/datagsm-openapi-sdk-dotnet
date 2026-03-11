using System.Text.Json.Serialization;

namespace Datagsm.OpenApi.Models;

/// <summary>정렬 방향</summary>
public enum SortDirection
{
    [JsonStringEnumMemberName("ASC")] Asc,
    [JsonStringEnumMemberName("DESC")] Desc
}
