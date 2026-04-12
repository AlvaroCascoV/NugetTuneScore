using System.Security.Claims;
using TuneScore.Constants;

namespace TuneScore.Helpers
{
    public static class ClaimsHelper
    {
        public const string AdminRoleName = Roles.Admin;
        public const string ArtistRoleName = Roles.Artist;

        public static bool IsLoggedIn(ClaimsPrincipal? user)
        {
            return user?.Identity?.IsAuthenticated == true;
        }

        public static int? GetUserId(ClaimsPrincipal? user)
        {
            var idValue = user?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return int.TryParse(idValue, out var id) ? id : null;
        }

        public static string? GetUsername(ClaimsPrincipal? user)
        {
            return user?.FindFirst(ClaimTypes.Name)?.Value;
        }

        public static string? GetEmail(ClaimsPrincipal? user)
        {
            return user?.FindFirst(ClaimTypes.Email)?.Value;
        }

        public static bool IsAdmin(ClaimsPrincipal? user)
        {
            return user?.IsInRole(AdminRoleName) == true;
        }

        public static bool IsArtist(ClaimsPrincipal? user)
        {
            return user?.IsInRole(ArtistRoleName) == true;
        }

        /// <summary>Returns the ArtistId stored in claims (set at login for Artist-role users).</summary>
        public static int? GetArtistId(ClaimsPrincipal? user)
        {
            var val = user?.FindFirst("ArtistId")?.Value;
            return int.TryParse(val, out var id) ? id : null;
        }
    }
}
