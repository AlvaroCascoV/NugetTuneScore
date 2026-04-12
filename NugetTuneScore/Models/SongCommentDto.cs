namespace TuneScore.Models;

public class SongCommentDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    /// <summary>True if the commenter is the artist of the song — shows the "Artista" badge.</summary>
    public bool IsArtistOfSong { get; set; }
    /// <summary>Score from the linked Rating; null for replies.</summary>
    public int? Score { get; set; }
    public string Content { get; set; } = string.Empty;
    public int? ParentCommentId { get; set; }
    public DateTime CreatedAt { get; set; }
    public int LikeCount { get; set; }
    public int DislikeCount { get; set; }
    /// <summary>Current user: true = like, false = dislike, null = no vote (or anonymous).</summary>
    public bool? UserVote { get; set; }
    public List<SongCommentDto> Replies { get; set; } = new();
}
