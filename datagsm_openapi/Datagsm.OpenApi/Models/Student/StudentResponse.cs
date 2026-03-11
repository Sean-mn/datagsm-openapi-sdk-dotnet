namespace Datagsm.OpenApi.Models;

/// <summary>학생 목록 조회 응답</summary>
public sealed class StudentResponse
{
    public int TotalPages { get; init; }
    public long TotalElements { get; init; }
    public IReadOnlyList<StudentDto> Students { get; init; } = [];
}
