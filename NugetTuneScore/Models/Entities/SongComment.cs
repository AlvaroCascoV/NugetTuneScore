using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetTuneScore.Models;

public class SongComment
{
    [Key]
    public int Id { get; set; }

    public int SongId { get; set; }

    public int UserId { get; set; }

    [StringLength(500)]
    public string Content { get; set; } = string.Empty;

    /// <summary>Null for top-level comments; set for replies.</summary>
    public int? ParentCommentId { get; set; }

    /// <summary>Always set for top-level comments; null for replies.</summary>
    public int? RatingId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("SongId")]
    public virtual Song Song { get; set; } = null!;

    [ForeignKey("UserId")]
    public virtual User User { get; set; } = null!;

    [ForeignKey("ParentCommentId")]
    public virtual SongComment? ParentComment { get; set; }

    [ForeignKey("RatingId")]
    public virtual Rating? Rating { get; set; }

    [InverseProperty("ParentComment")]
    public virtual ICollection<SongComment> Replies { get; set; } = new List<SongComment>();

    public virtual ICollection<SongCommentVote> Votes { get; set; } = new List<SongCommentVote>();
}
