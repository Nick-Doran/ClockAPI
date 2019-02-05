using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeZoneConverter;

namespace Clockwork.Web
{
    public static class Converter
    {
        public static string ConverterMethod(string toConvert)
        {
            try
            {
            return TZConvert.WindowsToIana(toConvert);
            }
            catch
            {
                return toConvert;
            }
        }
    }
}