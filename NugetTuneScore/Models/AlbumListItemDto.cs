namespace TuneScore.Models;

/// <summary>
/// Result shape for SP_PAGINACION_ALBUMES stored procedure (keyless mapping belongs in the API DbContext).
/// </summary>
public class AlbumListItemDto
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int ReleaseYear { get; set; }
    public string? ImageName { get; set; }
    public int ArtistId { get; set; }
    public string? ArtistName { get; set; }
}
