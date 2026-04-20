using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NugetTuneScore.Models;

[Keyless]
[Table("V_UserLogin")]
public class V_UserLogin
{
    [Column("Id")]
    public int Id { get; set; }

    [Column("Username")]
    public string Username { get; set; } = null!;

    [Column("Email")]
    public string Email { get; set; } = null!;

    [Column("PasswordPlain")]
    public string? PasswordPlain { get; set; }

    [Column("IsEmailVerified")]
    public bool IsEmailVerified { get; set; }

    [Column("PasswordHash")]
    public byte[]? PasswordHash { get; set; }

    [Column("Salt")]
    public string? Salt { get; set; }
}
