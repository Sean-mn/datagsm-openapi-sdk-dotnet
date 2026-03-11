using System.Text.Json.Serialization;

namespace Datagsm.OpenApi.Models;

/// <summary>학생 역할</summary>
public enum StudentRole
{
    [JsonStringEnumMemberName("STUDENT_COUNCIL")] StudentCouncil,
    [JsonStringEnumMemberName("DORMITORY_MANAGER")] DormitoryManager,
    [JsonStringEnumMemberName("GENERAL_STUDENT")] GeneralStudent,
    [JsonStringEnumMemberName("GRADUATE")] Graduate,
    [JsonStringEnumMemberName("WITHDRAWN")] Withdrawn
}
