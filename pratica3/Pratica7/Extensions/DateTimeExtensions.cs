using System;
using System.Globalization;

namespace Pratica7.Extensions
{
    class DateTimeExtensions
    {
        static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + "Hours";
            }
            else
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + "Days";
            }
        }
    }
}
