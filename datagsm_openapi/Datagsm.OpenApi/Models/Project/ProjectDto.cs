namespace Datagsm.OpenApi.Models;

/// <summary>프로젝트 상세 정보</summary>
public sealed class ProjectDto
{
    public long Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public ClubInfo Club { get; init; } = new();
    public IReadOnlyList<PersonDto> Participants { get; init; } = [];
}
