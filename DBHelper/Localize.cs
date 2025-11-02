using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHelper
{
    public static class Localize
    {
        public static string ToEnglishNumbers(this string data)
        {
            return data == null
                ? null
                : (string.IsNullOrWhiteSpace(data)
                    ? string.Empty
                    : data
                        .Replace("١", "1")
                        .Replace("٢", "2")
                        .Replace("٣", "3")
                        .Replace("٤", "4")
                        .Replace("٥", "5")
                        .Replace("٦", "6")
                        .Replace("٧", "7")
                        .Replace("٨", "8")
                        .Replace("٩", "9")
                        .Replace("٠", "0")

                        .Replace("۱", "1")
                        .Replace("۲", "2")
                        .Replace("۳", "3")
                        .Replace("۴", "4")
                        .Replace("۵", "5")
                        .Replace("۶", "6")
                        .Replace("۷", "7")
                        .Replace("۸", "8")
                        .Replace("۹", "9")
                        .Replace("۰", "0")
                        .Trim());
        }
    }
}
