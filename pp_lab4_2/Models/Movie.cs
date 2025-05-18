using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pp_lab4_2.Models;

public class Movie
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    [DataType(DataType.Date)]
    public DateTime? ReleaseDate { get; set; }

    [NotMapped]
    public double? Rate => RatingCount == 0 ? 0 : (double)TotalRate / RatingCount;

    public float TotalRate { get; set; }
    public float RatingCount { get; set; }

    public string? ImageUrl { get; set; }
}
