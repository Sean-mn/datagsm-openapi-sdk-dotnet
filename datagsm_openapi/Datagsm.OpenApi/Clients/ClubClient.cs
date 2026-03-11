using Datagsm.OpenApi.Models;

namespace Datagsm.OpenApi.Clients;

/// <summary>동아리 데이터 API 클라이언트. 필요 스코프: CLUB_READ</summary>
public sealed class ClubClient : BaseClient
{
    internal ClubClient(HttpClient httpClient) : base(httpClient) { }

    /// <summary>동아리 목록을 조회합니다.</summary>
    /// <param name="request">필터 및 페이지 옵션. null이면 기본값 적용.</param>
    /// <param name="cancellationToken">취소 토큰.</param>
    public Task<ClubResponse> GetClubsAsync(
        ClubRequest? request = null,
        CancellationToken cancellationToken = default)
    {
        var r = request ?? new ClubRequest();

        var queryParams = new []
        {
            ("clubId",                        r.ClubId?.ToString()),
            ("clubName",                      r.ClubName),
            ("clubType",                      ToApiString(r.ClubType)),
            ("includeLeaderInParticipants",   r.IncludeLeaderInParticipants?.ToString().ToLowerInvariant()),
            ("page",                          r.Page?.ToString()),
            ("size",                          r.Size?.ToString()),
            ("sortBy",                        ToApiString(r.SortBy)),
            ("sortDirection",                 ToApiString(r.SortDirection)),
        };

        return GetAsync<ClubResponse>("/v1/clubs", queryParams, cancellationToken);
    }
}
