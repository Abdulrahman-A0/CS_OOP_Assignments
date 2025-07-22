namespace OOP_05
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int _seconds)
        {
            Hours = _seconds / 3600;
            _seconds %= 3600;
            Minutes = _seconds / 60;
            Seconds = _seconds % 60;
        }

        public Duration(int _hours, int _minutes, int _seconds)
            : this(_hours * 3600 + _minutes * 60 + _seconds)
        {

        }

        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }



        public override bool Equals(object? obj)
        {
            Duration du = obj as Duration;
            if (du == null)
                return false;

            return this.Hours == du.Hours
                && this.Minutes == du.Minutes
                && this.Seconds == du.Seconds;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        #region Operators Overloading
        private int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.TotalSeconds() + d2.TotalSeconds());
        }
        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.TotalSeconds() + seconds);
        }
        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.TotalSeconds() + 60);
        }
        public static Duration operator --(Duration d)
        {
            return new Duration(d.TotalSeconds() - 60);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.TotalSeconds() - d2.TotalSeconds());
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() <= d2.TotalSeconds();
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() >= d2.TotalSeconds();
        }

        public static bool operator true(Duration d)
        {
            return d.TotalSeconds() > 0;
        }
        public static bool operator false(Duration d)
        {
            return d.TotalSeconds() <= 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return DateTime.Now.AddSeconds(d.TotalSeconds());
        }
        #endregion

    }
}
