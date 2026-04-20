using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NugetTuneScore.Constants;

namespace NugetTuneScore.Models;

public partial class Artist
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [StringLength(100)]
    [Column("Name")]
    public string Name { get; set; } = null!;

    [StringLength(300)]
    [Column("ImageName")]
    public string? ImageName { get; set; }

    [Column("CreatedAt")]
    public DateTime CreatedAt { get; set; }

    [StringLength(100)]
    [Column("City")]
    public string? City { get; set; }

    [StringLength(100)]
    [Column("Country")]
    public string? Country { get; set; }

    [Column("Latitude")]
    public double? Latitude { get; set; }

    [Column("Longitude")]
    public double? Longitude { get; set; }

    /// <summary>Active | Pending. Pending artists are hidden from public listings until approved.</summary>
    [StringLength(20)]
    [Column("Status")]
    public string Status { get; set; } = ArtistStatuses.Active;

    /// <summary>UserId of the user who submitted this artist profile during registration.</summary>
    [Column("CreatedByUserId")]
    public int? CreatedByUserId { get; set; }

    [InverseProperty("Artist")]
    public virtual ICollection<Album> Albums { get; set; } = new List<Album>();

    [InverseProperty("Artist")]
    public virtual ICollection<ArtistLinkRequest> LinkRequests { get; set; } = new List<ArtistLinkRequest>();
}
