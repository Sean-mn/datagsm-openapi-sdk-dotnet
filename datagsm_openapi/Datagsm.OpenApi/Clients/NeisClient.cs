using Datagsm.OpenApi.Models;

namespace Datagsm.OpenApi.Clients;

/// <summary>NEIS 급식/학사일정 API 클라이언트. 필요 스코프: NEIS_READ</summary>
public sealed class NeisClient : BaseClient
{
    internal NeisClient(HttpClient httpClient) : base(httpClient) { }

    /// <summary>급식 정보를 조회합니다.</summary>
    /// <param name="request">날짜 필터. null이면 오늘 날짜.</param>
    /// <param name="cancellationToken">취소 토큰.</param>
    public Task<IReadOnlyList<MealDto>> GetMealsAsync(
        MealRequest? request = null,
        CancellationToken cancellationToken = default)
    {
        var r = request ?? new MealRequest();

        var queryParams = new (string, string?)[]
        {
            ("date",      r.Date?.ToString("yyyy-MM-dd")),
            ("fromDate",  r.FromDate?.ToString("yyyy-MM-dd")),
            ("toDate",    r.ToDate?.ToString("yyyy-MM-dd")),
        };

        return GetAsync<IReadOnlyList<MealDto>>("/v1/neis/meals", queryParams, cancellationToken);
    }

    /// <summary>학사일정을 조회합니다.</summary>
    /// <param name="request">날짜 필터. null이면 오늘 날짜.</param>
    /// <param name="cancellationToken">취소 토큰.</param>
    public Task<IReadOnlyList<ScheduleDto>> GetSchedulesAsync(
        ScheduleRequest? request = null,
        CancellationToken cancellationToken = default)
    {
        var r = request ?? new ScheduleRequest();

        var queryParams = new (string, string?)[]
        {
            ("date",      r.Date?.ToString("yyyy-MM-dd")),
            ("fromDate",  r.FromDate?.ToString("yyyy-MM-dd")),
            ("toDate",    r.ToDate?.ToString("yyyy-MM-dd")),
        };

        return GetAsync<IReadOnlyList<ScheduleDto>>("/v1/neis/schedules", queryParams, cancellationToken);
    }
}
