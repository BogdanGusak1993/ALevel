using System.Runtime.CompilerServices;

namespace HomeWorkLeson1Library
{
    public  static class Class1
    {
        public static bool StartWithUpper(this string? str) {
            if (string.IsNullOrWhiteSpace(str))
                return false;
            char ch = str[0];
            return char.IsUpper(ch);
        }
    }
}