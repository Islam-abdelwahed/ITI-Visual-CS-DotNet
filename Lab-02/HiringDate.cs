using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_02
{
    public struct HiringDate
    {
        int day;
        int month;
        int year;

        public HiringDate(int day, int month, int year)
        {
            if (year < 1900 || year > DateTime.Now.Year)
                throw new ArgumentOutOfRangeException(nameof(year), "Year must be between 1900 and current year.");
            
            if (month < 1 || month > 12)
                throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12.");
            
            if (day < 1 || day > DateTime.DaysInMonth(year, month))
                throw new ArgumentOutOfRangeException(nameof(day), $"Day must be between 1 and {DateTime.DaysInMonth(year, month)} for the given month.");
            
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public override string ToString()
        {
            return $"{day:D2}/{month:D2}/{year}";
        }
        public static int CompareDates(HiringDate d1, HiringDate d2)
        {
            if (d1.year != d2.year)
                return d1.year - d2.year;

            if (d1.month != d2.month)
                return d1.month - d2.month;

            return d1.day - d2.day;
        }

    }
}