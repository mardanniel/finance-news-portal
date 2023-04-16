using System.Globalization;

namespace FinanceNewsPortal.Web.Helper
{
    public static class DateTimeExtensions
    {
        public static string ToFullDateString(this DateTime dateTime)
        {
            if (dateTime == null) return string.Empty;

            List<string> Months = new List<string>
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            string month = Months[dateTime.Month];
            int day = dateTime.Day;
            int year = dateTime.Year;

            int hour = dateTime.Hour;
            int minute = dateTime.Minute;
            string period = dateTime.ToString("tt", CultureInfo.InvariantCulture);

            string fullDateString = $"{month} {day}, {year}";

            return fullDateString;
        }

        public static string GetPreviousDayWithinWeekdays(this DateTime dateTime)
        {
            if (dateTime == null) return string.Empty;
            
            DateTime resultDate = dateTime;

            if (dateTime.DayOfWeek - 1 == DayOfWeek.Saturday || dateTime.DayOfWeek - 1 == DayOfWeek.Sunday)
            {
                while (resultDate.DayOfWeek != DayOfWeek.Friday)
                {
                    TimeSpan oneDay = new TimeSpan(24, 0, 0);
                    resultDate = resultDate.Subtract(oneDay);
                }
            }

            int year = resultDate.Year;
            string month = resultDate.Month.ToString("00");
            string currentDay = resultDate.Day.ToString("00");

            string previousDay = $"{year}-{month}-{currentDay}";
            return previousDay;
        }
    }
}