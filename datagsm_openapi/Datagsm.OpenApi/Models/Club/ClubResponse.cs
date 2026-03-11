namespace Datagsm.OpenApi.Models;

/// <summary>동아리 목록 조회 응답</summary>
public sealed class ClubResponse
{
    public int TotalPages { get; init; }
    public long TotalElements { get; init; }
    public IReadOnlyList<ClubDto> Clubs { get; init; } = [];
}
