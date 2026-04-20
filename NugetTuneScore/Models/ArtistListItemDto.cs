namespace NugetTuneScore.Models;

/// <summary>
/// Result shape for SP_PAGINACION_ARTISTAS stored procedure (keyless mapping belongs in the API DbContext).
/// </summary>
public class ArtistListItemDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? ImageName { get; set; }
    public string? Country { get; set; }
}
