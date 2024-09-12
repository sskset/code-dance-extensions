using System.Text.RegularExpressions;

namespace CodeDance.Extensions
{
    public static class StringExtensions
    {
        public static bool IsEmail(this string value)
        {
            // Regular expression pattern to match a valid email format
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(value, pattern);
        }
    }
}
