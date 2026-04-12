namespace TuneScore.Models;

//Una fila de una valoración para el perfil del usuario (canción, puntuación, comentario, fechas).
public class UserRatingItemDto
{
    public int SongId { get; set; }
    public string SongTitle { get; set; } = string.Empty;
    public int Score { get; set; }
    public string? Comment { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
