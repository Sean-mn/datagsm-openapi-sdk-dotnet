namespace Datagsm.OpenApi.Models;

/// <summary>프로젝트 목록 조회 응답</summary>
public sealed class ProjectResponse
{
    public int TotalPages { get; init; }
    public long TotalElements { get; init; }
    public IReadOnlyList<ProjectDto> Projects { get; init; } = [];
}
