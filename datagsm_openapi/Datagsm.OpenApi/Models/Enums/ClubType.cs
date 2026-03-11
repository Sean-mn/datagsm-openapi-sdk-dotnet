using System.Text.Json.Serialization;

namespace Datagsm.OpenApi.Models;

/// <summary>동아리 유형</summary>
public enum ClubType
{
    [JsonStringEnumMemberName("MAJOR_CLUB")] MajorClub,
    [JsonStringEnumMemberName("AUTONOMOUS_CLUB")] AutonomousClub
}
