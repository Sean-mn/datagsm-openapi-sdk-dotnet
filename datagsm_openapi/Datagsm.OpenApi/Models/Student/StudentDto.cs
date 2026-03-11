namespace Datagsm.OpenApi.Models;

/// <summary>학생 상세 정보</summary>
public sealed class StudentDto
{
    public long Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public Sex Sex { get; init; }
    public string Email { get; init; } = string.Empty;
    public int? Grade { get; init; }
    public int? ClassNum { get; init; }
    public int? Number { get; init; }
    public int? StudentNumber { get; init; }
    public Major? Major { get; init; }
    public StudentRole Role { get; init; }
    public int? DormitoryFloor { get; init; }
    public int? DormitoryRoom { get; init; }
    public ClubInfo? MajorClub { get; init; }
    public ClubInfo? AutonomousClub { get; init; }
}
