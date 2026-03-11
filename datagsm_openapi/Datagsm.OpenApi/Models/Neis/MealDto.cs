namespace Datagsm.OpenApi.Models;

/// <summary>급식 정보</summary>
public sealed class MealDto
{
    public string MealId { get; init; } = string.Empty;
    public string SchoolCode { get; init; } = string.Empty;
    public string SchoolName { get; init; } = string.Empty;
    public string OfficeCode { get; init; } = string.Empty;
    public string OfficeName { get; init; } = string.Empty;
    public DateOnly MealDate { get; init; }
    public MealType MealType { get; init; }
    public IReadOnlyList<string> MealMenu { get; init; } = [];
    public IReadOnlyList<string?> MealAllergyInfo { get; init; } = [];
    public string? MealCalories { get; init; }
    public string? OriginInfo { get; init; }
    public string? NutritionInfo { get; init; }
    public int? MealServeCount { get; init; }
}
