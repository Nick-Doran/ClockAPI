using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clockwork.Web
{
    public static class TimeZoneList
    {
       public static  SelectListItem[] TimezoneSelectList(){
            TimeZoneInfo.GetSystemTimeZones();
            TimezoneList = tzs.Select(tz => new SelectListItem()
        {
            Text = tz.DisplayName,
                Value = tz.Id
            }).ToArray();

        public
        public TimeZoneList
        {

        }
    }
}