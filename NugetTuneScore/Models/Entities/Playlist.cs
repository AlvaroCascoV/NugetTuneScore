using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NugetTuneScore.Models;

[Index("UserId", Name = "IX_Playlists_UserId")]
public partial class Playlist
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [Column("UserId")]
    public int UserId { get; set; }

    [StringLength(150)]
    [Column("Name")]
    public string Name { get; set; } = null!;

    [StringLength(500)]
    [Column("Description")]
    public string? Description { get; set; }

    [StringLength(300)]
    [Column("ImageName")]
    public string? ImageName { get; set; }

    [Column("CreatedAt")]
    public DateTime CreatedAt { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Playlists")]
    public virtual User User { get; set; } = null!;

    [InverseProperty("Playlist")]
    public virtual ICollection<PlaylistSong> PlaylistSongs { get; set; } = new List<PlaylistSong>();
}
