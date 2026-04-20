using System.Collections.Generic;

namespace NugetTuneScore.Models
{
    public class RatingSummary
    {
        public int TargetId { get; set; }

        /// <summary>Average raw score in the 1–10 scale.</summary>
        public double AverageScore { get; set; }

        /// <summary>Average score converted to 0–5 stars (can include halves).</summary>
        public double AverageStars { get; set; }

        /// <summary>Total number of ratings contributing to this summary.</summary>
        public int RatingsCount { get; set; }

        /// <summary>Current user's score in the 1–10 scale, if any.</summary>
        public int? UserScore { get; set; }

        /// <summary>
        /// Current user's comment text (loaded from SongComments linked to their rating).
        /// Null if the user has not commented.
        /// </summary>
        public string? UserComment { get; set; }
    }
}
