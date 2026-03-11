namespace Datagsm.OpenApi.Models;

/// <summary>학생 기본 정보 (동아리/프로젝트 참여자 목록에서 사용)</summary>
public sealed class PersonDto
{
    public long Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public int? StudentNumber { get; init; }
    public Major? Major { get; init; }
    public Sex Sex { get; init; }
}
