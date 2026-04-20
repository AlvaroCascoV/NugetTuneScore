using System.Security.Cryptography;

namespace NugetTuneScore.Helpers;

public static class OtpHelper
{
    private const int DefaultOtpLength = 6;

    /// <summary>
    /// Generates a cryptographically random numeric OTP (e.g. 6 digits).
    /// </summary>
    public static string GenerateOtp(int length = DefaultOtpLength)
    {
        if (length <= 0 || length > 10) length = DefaultOtpLength;
        var bytes = new byte[length];
        using (var rng = RandomNumberGenerator.Create())
            rng.GetBytes(bytes);
        var sb = new System.Text.StringBuilder(length);
        for (int i = 0; i < length; i++)
            sb.Append((bytes[i] % 10).ToString());
        return sb.ToString();
    }

    /// <summary>
    /// Returns expiry time for OTP (e.g. 15 minutes from now).
    /// </summary>
    public static DateTime GetOtpExpiry(TimeSpan validFor)
    {
        return DateTime.UtcNow.Add(validFor);
    }

    public static readonly TimeSpan DefaultVerificationExpiry = TimeSpan.FromMinutes(15);
    public static readonly TimeSpan DefaultPasswordResetExpiry = TimeSpan.FromMinutes(15);

    /// <summary>
    /// Normalizes an OTP string for comparison: digits only. Use when comparing user input (e.g. from copy-paste) to stored token.
    /// </summary>
    public static string NormalizeOtpForComparison(string? input)
    {
        if (string.IsNullOrWhiteSpace(input)) return "";
        return new string(input.Where(char.IsDigit).ToArray());
    }
}
