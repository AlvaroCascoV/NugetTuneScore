using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetTuneScore.Models;

public class CityLocation
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [Column("City")]
    public string City { get; set; } = null!;

    [Required]
    [StringLength(100)]
    [Column("Country")]
    public string Country { get; set; } = null!;

    [Column("Latitude")]
    public double Latitude { get; set; }

    [Column("Longitude")]
    public double Longitude { get; set; }

    [Column("LastUpdated")]
    public DateTime LastUpdated { get; set; }
}
