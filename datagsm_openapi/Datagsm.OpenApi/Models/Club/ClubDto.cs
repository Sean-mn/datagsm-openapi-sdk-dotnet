namespace Datagsm.OpenApi.Models;

/// <summary>동아리 상세 정보</summary>
public sealed class ClubDto
{
    public long Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public ClubType Type { get; init; }

    /// <summary>부장 정보. 졸업 또는 자퇴한 경우 null.</summary>
    public PersonDto? Leader { get; init; }

    public IReadOnlyList<PersonDto> Participants { get; init; } = [];
}
