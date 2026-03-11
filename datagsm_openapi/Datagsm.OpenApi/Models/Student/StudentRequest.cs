namespace Datagsm.OpenApi.Models;

/// <summary>학생 목록 조회 요청 파라미터</summary>
public sealed class StudentRequest
{
    /// <summary>학생 ID 필터</summary>
    public long? StudentId { get; set; }

    /// <summary>이름 필터</summary>
    public string? Name { get; set; }

    /// <summary>이메일 필터</summary>
    public string? Email { get; set; }

    /// <summary>학년 필터 (1–3)</summary>
    public int? Grade { get; set; }

    /// <summary>반 번호 필터 (1–4)</summary>
    public int? ClassNum { get; set; }

    /// <summary>번호 필터 (1–18)</summary>
    public int? Number { get; set; }

    /// <summary>성별 필터</summary>
    public Sex? Sex { get; set; }

    /// <summary>역할 필터</summary>
    public StudentRole? Role { get; set; }

    /// <summary>기숙사 호실 필터</summary>
    public int? DormitoryRoom { get; set; }

    /// <summary>졸업생 포함 여부 (기본값: false)</summary>
    public bool? IncludeGraduates { get; set; }

    /// <summary>자퇴생 포함 여부 (기본값: false)</summary>
    public bool? IncludeWithdrawn { get; set; }

    /// <summary>재학생만 조회 (기본값: false, IncludeGraduates/IncludeWithdrawn을 override)</summary>
    public bool? OnlyEnrolled { get; set; }

    /// <summary>페이지 번호 (기본값: 0)</summary>
    public int? Page { get; set; }

    /// <summary>페이지 크기 (기본값: 300)</summary>
    public int? Size { get; set; }

    /// <summary>정렬 기준</summary>
    public StudentSortBy? SortBy { get; set; }

    /// <summary>정렬 방향 (기본값: ASC)</summary>
    public SortDirection? SortDirection { get; set; }
}
