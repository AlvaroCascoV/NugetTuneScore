namespace NugetTuneScore.Models;

/// <summary>
/// Result shape for SP_PAGINACION_CANCIONES stored procedure (keyless mapping belongs in the API DbContext).
/// </summary>
public class SongListItemDto
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int? DurationSeconds { get; set; }
    public string? AlbumTitle { get; set; }
    public string? AlbumImageName { get; set; }
    public string? GenreName { get; set; }
}
