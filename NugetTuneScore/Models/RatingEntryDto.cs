namespace NugetTuneScore.Models;

/// <summary>
/// A single rating shown in the list (user, score, comment).
/// </summary>
public class RatingEntryDto
{
    public string UserName { get; set; } = string.Empty;
    public int Score { get; set; }
    public string? Comment { get; set; }
}
