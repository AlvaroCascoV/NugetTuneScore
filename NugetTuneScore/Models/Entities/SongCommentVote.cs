using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetTuneScore.Models;

public class SongCommentVote
{
    [Key]
    public int Id { get; set; }

    public int SongCommentId { get; set; }

    public int UserId { get; set; }

    /// <summary>True = like, false = dislike.</summary>
    public bool IsLike { get; set; }

    [ForeignKey("SongCommentId")]
    public virtual SongComment SongComment { get; set; } = null!;

    [ForeignKey("UserId")]
    public virtual User User { get; set; } = null!;
}
