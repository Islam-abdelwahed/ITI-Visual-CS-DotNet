using System;
using System.Collections.Generic;
using System.Text;

namespace lab_03.Models
{
    internal class Duration
    {
        private int hours;
        private int minutes;
        private int seconds;

        public int Hours
        {
            get => hours;
            set
            {
                hours = value;
                Normalize();
            }
        }

        public int Minutes
        {
            get => minutes;
            set
            {
                minutes = value;
                Normalize();
            }
        }

        public int Seconds
        {
            get => seconds;
            set
            {
                seconds = value;
                Normalize();
            }
        }

        private void Normalize()
        {
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;

            if (totalSeconds < 0)
                totalSeconds = 0;

            hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            minutes = totalSeconds / 60;
            seconds = totalSeconds % 60;
        }

        public Duration() { }

        public Duration(int totalSeconds)
        {
            seconds = totalSeconds;
            Normalize();
        }

        public Duration(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
            Normalize();
        }
        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
            else
                return $"Minutes :{Minutes}, Seconds :{Seconds}";
        }


        public override bool Equals(object? obj)
        {
            // ereor
            if (obj == null || (obj.GetType() != typeof (Duration)))
                return false;

            Duration other = (Duration)obj;
            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }

        private int ToTotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.ToTotalSeconds() + d2.ToTotalSeconds());
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.ToTotalSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(d.ToTotalSeconds() + seconds);
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.ToTotalSeconds() + 60);
        }
        public static Duration operator --(Duration d)
        {
            return new Duration(d.ToTotalSeconds() - 60);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() > d2.ToTotalSeconds();
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() < d2.ToTotalSeconds();
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() >= d2.ToTotalSeconds();
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
        }

        public static bool operator true(Duration d)
        {
            return d.ToTotalSeconds() > 0;
        }
        public static bool operator false(Duration d)
        {
            return d.ToTotalSeconds() <= 0;
        }
        public static explicit operator DateTime(Duration d)
        {
            return DateTime.Today
                .AddHours(d.Hours)
                .AddMinutes(d.Minutes)
                .AddSeconds(d.Seconds);
        }
    }
}
