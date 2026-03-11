namespace Datagsm.OpenApi.Models;

/// <summary>학사일정 정보</summary>
public sealed class ScheduleDto
{
    public string ScheduleId { get; init; } = string.Empty;
    public string SchoolCode { get; init; } = string.Empty;
    public string SchoolName { get; init; } = string.Empty;
    public string OfficeCode { get; init; } = string.Empty;
    public string OfficeName { get; init; } = string.Empty;
    public DateOnly ScheduleDate { get; init; }
    public string AcademicYear { get; init; } = string.Empty;
    public string EventName { get; init; } = string.Empty;
    public string? EventContent { get; init; }
    public string? DayCategory { get; init; }
    public string? SchoolCourseType { get; init; }
    public string? DayNightType { get; init; }
    public IReadOnlyList<int> TargetGrades { get; init; } = [];
}
