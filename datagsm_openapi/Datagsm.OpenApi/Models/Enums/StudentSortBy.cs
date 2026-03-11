using System.Text.Json.Serialization;

namespace Datagsm.OpenApi.Models;

/// <summary>학생 정렬 기준</summary>
public enum StudentSortBy
{
    [JsonStringEnumMemberName("ID")] Id,
    [JsonStringEnumMemberName("NAME")] Name,
    [JsonStringEnumMemberName("EMAIL")] Email,
    [JsonStringEnumMemberName("STUDENT_NUMBER")] StudentNumber,
    [JsonStringEnumMemberName("GRADE")] Grade,
    [JsonStringEnumMemberName("CLASS_NUM")] ClassNum,
    [JsonStringEnumMemberName("NUMBER")] Number,
    [JsonStringEnumMemberName("MAJOR")] Major,
    [JsonStringEnumMemberName("ROLE")] Role,
    [JsonStringEnumMemberName("SEX")] Sex,
    [JsonStringEnumMemberName("DORMITORY_ROOM")] DormitoryRoom
}
