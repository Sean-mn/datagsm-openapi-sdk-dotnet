namespace Datagsm.OpenApi.Models;

/// <summary>동아리 목록 조회 요청 파라미터</summary>
public sealed class ClubRequest
{
    /// <summary>동아리 ID 필터</summary>
    public long? ClubId { get; set; }

    /// <summary>동아리 이름 필터</summary>
    public string? ClubName { get; set; }

    /// <summary>동아리 유형 필터</summary>
    public ClubType? ClubType { get; set; }

    /// <summary>참여자 목록에 부장 포함 여부</summary>
    public bool? IncludeLeaderInParticipants { get; set; }

    /// <summary>페이지 번호 (기본값: 0)</summary>
    public int? Page { get; set; }

    /// <summary>페이지 크기 (기본값: 100)</summary>
    public int? Size { get; set; }

    /// <summary>정렬 기준</summary>
    public ClubSortBy? SortBy { get; set; }

    /// <summary>정렬 방향 (기본값: ASC)</summary>
    public SortDirection? SortDirection { get; set; }
}
