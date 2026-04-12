namespace TuneScore.Constants;

/// <summary>Rating-linked top-level comments vs threaded replies.</summary>
public static class CommentLimits
{
    /// <summary>Max length for comments tied to a song rating (SongComments with RatingId).</summary>
    public const int MaxTopLevelCommentLength = 300;

    /// <summary>Max length for replies (SongComments with ParentCommentId).</summary>
    public const int MaxReplyLength = 500;
}
