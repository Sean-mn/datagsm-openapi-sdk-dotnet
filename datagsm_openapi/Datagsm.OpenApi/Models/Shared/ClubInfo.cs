namespace Datagsm.OpenApi.Models;

/// <summary>동아리 간략 정보 (학생 조회 응답에서 사용)</summary>
public sealed class ClubInfo
{
    public long Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public ClubType Type { get; init; }
}
