using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valhalla.Time
{
    /// <summary>
    /// Represents a time in 24-hr format.
    /// </summary>
    public class MilitaryTime
    {
        /// <summary>
        /// Hour value (e.g. for 14:36, use 14)
        /// </summary>
        int Hours { get; set; }

        /// <summary>
        /// Minute value (e.g. for 14:36, use 36)
        /// </summary>
        int Minutes { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="h">Hours</param>
        /// <param name="m">Minutes</param>
        public MilitaryTime(int h, int m)
        {
            Hours = h;
            Minutes = m;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", Hours.ToString("D2"), Minutes.ToString("D2"));
        }

        /// <summary>
        /// Returns the time as a string in 12-hr format
        /// </summary>
        /// <returns>Time in 12-hr format</returns>
        public string To12HrString()
        {
            var meridian = "AM";
            var hours = Hours;
            var minutes = Minutes.ToString("D2");

            // If hours after noon, subtract twelve and change AM to PM
            if (Hours > 12) { hours -= 12; }
            meridian = "PM";

            return string.Format("{0}:{1} {2}", hours, minutes, meridian);
        }
    }
}
