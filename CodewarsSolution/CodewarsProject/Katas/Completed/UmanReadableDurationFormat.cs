namespace CodewarsProject
{
    using System;

    public class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            int minutes = 0, hours = 0, days = 0, years = 0;
            string result = string.Empty;
            string toBeAdded = "";
            if (seconds > 60)
            {
                minutes = Math.DivRem(seconds, 60, out seconds);
            }
            if (minutes > 60)
            {
                hours = Math.DivRem(minutes, 60, out minutes);
            }
            if (hours > 24)
            {
                days = Math.DivRem(hours, 24, out hours);
            }
            if (days > 365)
            {
                years = Math.DivRem(days, 365, out days);
            }

            if (years > 0)
            {
                result = string.Concat(years, years == 1 ? " year" : " years");
            }

            if (days > 0)
            {
                toBeAdded = string.Concat(days, days == 1 ? " day" : " days");
                if (string.IsNullOrEmpty(result))
                {
                    result = toBeAdded;
                }
                else if (hours == 0 && minutes == 0 && seconds == 0)
                {
                    result += " and " + toBeAdded;
                }
                else
                {
                    result += ", " + toBeAdded;
                }
            }

            if (hours > 0)
            {
                toBeAdded = string.Concat(hours, hours == 1 ? " hour" : " hours");
                if (string.IsNullOrEmpty(result))
                {
                    result = toBeAdded;
                }
                else if (minutes == 0 && seconds == 0)
                {
                    result += " and " + toBeAdded;
                }
                else
                {
                    result += ", " + toBeAdded;
                }
            }

            if (minutes > 0)
            {
                toBeAdded = string.Concat(minutes, minutes == 1 ? " minute" : " minutes");
                if (string.IsNullOrEmpty(result))
                {
                    result = toBeAdded;
                }
                else if (seconds == 0)
                {
                    result += " and " + toBeAdded;
                }
                else
                {
                    result += ", " + toBeAdded;
                }
            }

            if (seconds > 0)
            {
                toBeAdded = string.Concat(seconds, seconds == 1 ? " second" : " seconds");
                if (string.IsNullOrEmpty(result))
                {
                    result = toBeAdded;
                }
                else
                {
                    result += " and " + toBeAdded;
                }
            }
            if (string.IsNullOrEmpty(result))
            {
                return "now";
            }
            return result;
        }
    }
}
