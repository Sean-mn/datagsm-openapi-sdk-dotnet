using System.Text.Json.Serialization;

namespace Datagsm.OpenApi.Models;

/// <summary>급식 타입</summary>
public enum MealType
{
    [JsonStringEnumMemberName("BREAKFAST")] Breakfast,
    [JsonStringEnumMemberName("LUNCH")] Lunch,
    [JsonStringEnumMemberName("DINNER")] Dinner
}
