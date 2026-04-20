using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NugetTuneScore.Constants;

namespace NugetTuneScore.Models;

public partial class Song
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [StringLength(150)]
    [Column("Title")]
    public string Title { get; set; } = null!;

    [Column("DurationSeconds")]
    public int? DurationSeconds { get; set; }

    [Column("AlbumId")]
    public int AlbumId { get; set; }

    [Column("GenreId")]
    public int GenreId { get; set; }

    [Column("CreatedAt")]
    public DateTime CreatedAt { get; set; }

    /// <summary>Approved | Pending. Artist-created songs start as Pending until admin approves.</summary>
    [StringLength(20)]
    [Column("ContentStatus")]
    public string ContentStatus { get; set; } = ContentStatuses.Approved;

    [Column("DeleteRequested")]
    public bool DeleteRequested { get; set; }

    [Column("DeleteRequestedAt")]
    public DateTime? DeleteRequestedAt { get; set; }

    [ForeignKey("AlbumId")]
    [InverseProperty("Songs")]
    public virtual Album Album { get; set; } = null!;

    [ForeignKey("GenreId")]
    [InverseProperty("Songs")]
    public virtual Genre Genre { get; set; } = null!;

    [InverseProperty("Song")]
    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();

    [InverseProperty("Song")]
    public virtual ICollection<PlaylistSong> PlaylistSongs { get; set; } = new List<PlaylistSong>();

    [InverseProperty("Song")]
    public virtual ICollection<SongComment> SongComments { get; set; } = new List<SongComment>();
}
