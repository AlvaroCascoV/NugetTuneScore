using System.ComponentModel.DataAnnotations.Schema;

namespace NugetTuneScore.Models;

public class PlaylistSong
{
    [Column("PlaylistId")]
    public int PlaylistId { get; set; }

    [Column("SongId")]
    public int SongId { get; set; }

    [Column("Position")]
    public int Position { get; set; }

    [ForeignKey("PlaylistId")]
    [InverseProperty("PlaylistSongs")]
    public virtual Playlist Playlist { get; set; } = null!;

    [ForeignKey("SongId")]
    [InverseProperty("PlaylistSongs")]
    public virtual Song Song { get; set; } = null!;
}
