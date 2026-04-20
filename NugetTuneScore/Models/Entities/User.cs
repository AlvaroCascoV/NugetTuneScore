using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NugetTuneScore.Models;

[Index("Username", Name = "UQ__Users__536C85E49F41945E", IsUnique = true)]
[Index("Email", Name = "UQ__Users__A9D10534A170B2FB", IsUnique = true)]
public partial class User
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [StringLength(50)]
    [Column("Username")]
    public string Username { get; set; } = null!;

    [StringLength(100)]
    [Column("Email")]
    public string Email { get; set; } = null!;

    [Column("PasswordPlain")]
    public string? PasswordPlain { get; set; }

    [StringLength(20)]
    [Column("Role")]
    public string Role { get; set; } = null!;

    [Column("CreatedAt")]
    public DateTime CreatedAt { get; set; }

    [Column("IsEmailVerified")]
    public bool IsEmailVerified { get; set; }

    [Column("IsDisabled")]
    public bool IsDisabled { get; set; }

    [StringLength(20)]
    [Column("EmailVerificationToken")]
    public string? EmailVerificationToken { get; set; }

    [Column("EmailVerificationExpiry")]
    public DateTime? EmailVerificationExpiry { get; set; }

    [StringLength(20)]
    [Column("PasswordResetToken")]
    public string? PasswordResetToken { get; set; }

    [Column("PasswordResetExpiry")]
    public DateTime? PasswordResetExpiry { get; set; }

    /// <summary>Set after admin approves an artist link request.</summary>
    [Column("ArtistId")]
    public int? ArtistId { get; set; }

    /// <summary>"Artist" while a link request is pending; null otherwise.</summary>
    [StringLength(20)]
    [Column("PendingRole")]
    public string? PendingRole { get; set; }

    [ForeignKey("ArtistId")]
    public virtual Artist? LinkedArtist { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();

    [InverseProperty("User")]
    public virtual UserSalt? UserSalt { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Playlist> Playlists { get; set; } = new List<Playlist>();

    [InverseProperty("User")]
    public virtual ICollection<SongComment> SongComments { get; set; } = new List<SongComment>();

    [InverseProperty("User")]
    public virtual ICollection<SongCommentVote> SongCommentVotes { get; set; } = new List<SongCommentVote>();

    [InverseProperty("User")]
    public virtual ICollection<ArtistLinkRequest> ArtistLinkRequests { get; set; } = new List<ArtistLinkRequest>();
}
