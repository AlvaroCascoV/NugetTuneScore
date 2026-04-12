namespace TuneScore.Models;

/// <summary>
/// Entidad top-rated (artista, álbum o canción) para la página de inicio.
/// </summary>
public class TopRatedItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double AverageScore { get; set; }
    /// <summary>Imagen para la tarjeta. Para canciones, esta es la imagen del álbum (usar carpeta Albums).</summary>
    public string? ImageName { get; set; }
}

public class TopRatedViewModel
{
    public TopRatedItem? TopArtist { get; set; }
    public TopRatedItem? TopAlbum { get; set; }
    public TopRatedItem? TopSong { get; set; }
}
