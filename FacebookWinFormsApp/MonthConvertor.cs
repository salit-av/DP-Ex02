using System;
using System.Globalization;

namespace BasicFacebookFeatures
{
    internal class MonthConverter
    {
        internal MonthConverter() { }

        internal int GetMonthNumber(string i_MonthName)
        {
            DateTimeFormatInfo formatInfo = DateTimeFormatInfo.InvariantInfo;
            DateTime date = DateTime.ParseExact(i_MonthName, "MMMM", formatInfo);
            return date.Month;
        }
    }
}