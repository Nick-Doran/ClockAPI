using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clockwork.Web.Models
{
    public class TimeZonesList
    {
        public ReadOnlyCollection<TimeZoneInfo> TimeZones
        {
            get
            {
                return TimeZoneInfo.GetSystemTimeZones();
            }
            private set { }
        }

        public SelectList List = new SelectList(TimeZones)

    }
}