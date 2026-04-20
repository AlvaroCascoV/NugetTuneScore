using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NugetTuneScore.Constants;

namespace NugetTuneScore.Models;

public class ArtistLinkRequest
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }

    public int ArtistId { get; set; }

    /// <summary>True when the user created a new artist profile during registration.</summary>
    public bool IsNewArtist { get; set; }

    /// <summary>Pending | Approved | Rejected</summary>
    [StringLength(20)]
    public string Status { get; set; } = RequestStatuses.Pending;

    public DateTime CreatedAt { get; set; }

    public DateTime? ReviewedAt { get; set; }

    public int? ReviewedByAdminId { get; set; }

    [ForeignKey("UserId")]
    public virtual User User { get; set; } = null!;

    [ForeignKey("ArtistId")]
    public virtual Artist Artist { get; set; } = null!;

    [ForeignKey("ReviewedByAdminId")]
    public virtual User? ReviewedByAdmin { get; set; }
}
