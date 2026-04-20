using System;
using System.Globalization;
using System.Linq;

namespace NugetTuneScore.Helpers;

public static class CountryFlagHelper
{
    private static readonly Lazy<RegionInfo[]> Regions = new(() =>
    {
        return CultureInfo
            .GetCultures(CultureTypes.SpecificCultures)
            .Select(c =>
            {
                try
                {
                    return new RegionInfo(c.Name);
                }
                catch
                {
                    return null;
                }
            })
            .Where(r => r != null)
            .GroupBy(r => r!.TwoLetterISORegionName)
            .Select(g => g.First()!)
            .ToArray();
    });

    public static string? GetFlagCode(string? country)
    {
        if (string.IsNullOrWhiteSpace(country))
        {
            return null;
        }

        if (country.Length == 2)
        {
            return country.ToLowerInvariant();
        }

        var regions = Regions.Value;
        var region = regions.FirstOrDefault(
            r =>
                r.EnglishName.Equals(country, StringComparison.OrdinalIgnoreCase) ||
                // Let users input the country in their local language (e.g. "España").
                r.NativeName.Equals(country, StringComparison.OrdinalIgnoreCase) ||
                r.DisplayName.Equals(country, StringComparison.OrdinalIgnoreCase));

        return region?.TwoLetterISORegionName.ToLowerInvariant();
    }
}


