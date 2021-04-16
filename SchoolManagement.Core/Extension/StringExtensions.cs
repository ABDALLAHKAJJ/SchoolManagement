using System;

namespace SchoolManagement.Libraries.Core.Extension
{
    public static class StringExtensions
    {
        public static string PhoneNumber(this string num)
        {
            return String.Format("{0:(###) ###-####}", num);
        }
    }
}