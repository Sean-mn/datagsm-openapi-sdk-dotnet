using Datagsm.OpenApi.Models;

namespace Datagsm.OpenApi.Clients;

/// <summary>프로젝트 데이터 API 클라이언트. 필요 스코프: PROJECT_READ</summary>
public sealed class ProjectClient : BaseClient
{
    internal ProjectClient(HttpClient httpClient) : base(httpClient) { }

    /// <summary>프로젝트 목록을 조회합니다.</summary>
    /// <param name="request">필터 및 페이지 옵션. null이면 기본값 적용.</param>
    /// <param name="cancellationToken">취소 토큰.</param>
    public Task<ProjectResponse> GetProjectsAsync(
        ProjectRequest? request = null,
        CancellationToken cancellationToken = default)
    {
        var r = request ?? new ProjectRequest();

        var queryParams = new (string, string?)[]
        {
            ("projectId",      r.ProjectId?.ToString()),
            ("projectName",    r.ProjectName),
            ("clubId",         r.ClubId?.ToString()),
            ("page",           r.Page?.ToString()),
            ("size",           r.Size?.ToString()),
            ("sortBy",         ToApiString(r.SortBy)),
            ("sortDirection",  ToApiString(r.SortDirection)),
        };

        return GetAsync<ProjectResponse>("/v1/projects", queryParams, cancellationToken);
    }
}
