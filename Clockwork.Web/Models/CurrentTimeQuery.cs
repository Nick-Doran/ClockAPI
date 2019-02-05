﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeZoneConverter;

namespace Clockwork.Web.Models
{
    public class CurrentTimeQuery
    {
        public int CurrentTimeQueryId { get; set; }
        public DateTime Time { get; set; }
        public string ClientIp { get; set; }
        public DateTime UTCTime { get; set; }
        public string TimezoneId { get; set; }
        public SelectListItem[] TimezoneList { get; set; }

        public CurrentTimeQuery()
        {
            try
            {
                var tzs = TimeZoneInfo.GetSystemTimeZones();
                TimezoneList = tzs.Select(tz => new SelectListItem()
                {

                    Text = tz.DisplayName.Substring(12),
                    Value = TZConvert.WindowsToIana(tz.Id)
                }).ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}