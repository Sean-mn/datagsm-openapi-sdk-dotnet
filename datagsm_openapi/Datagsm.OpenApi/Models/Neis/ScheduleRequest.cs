namespace Datagsm.OpenApi.Models;

/// <summary>학사일정 조회 요청 파라미터</summary>
public sealed class ScheduleRequest
{
    /// <summary>단일 날짜 조회 (예: 2025-12-15). 생략 시 오늘 날짜.</summary>
    public DateOnly? Date { get; set; }

    /// <summary>범위 조회 시작 날짜</summary>
    public DateOnly? FromDate { get; set; }

    /// <summary>범위 조회 종료 날짜</summary>
    public DateOnly? ToDate { get; set; }
}
