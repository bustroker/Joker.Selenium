using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo.Tests
{
    public static class TestEnvironment
    {
        private static string cmsBaseUrl;
        private static string bookingBaseUrl;

        /// <summary>
        /// Base url for cms. Ej. in PRO: http://www.iberiaexpress.com
        /// </summary>
        public static string CmsBaseUrl
        {
            get
            {
                if (cmsBaseUrl == null)
                {
                    cmsBaseUrl = ConfigurationManager.AppSettings.Get("cmsBaseUrl");
                }

                return cmsBaseUrl;
            }
        }

        /// <summary>
        /// Base url for booking. Ej. in PRO: http://booking.iberiaexpress.com
        /// </summary>
        public static string BookingBaseUrl
        {
            get
            {
                if (bookingBaseUrl == null)
                {
                    bookingBaseUrl = ConfigurationManager.AppSettings.Get("bookingBaseUrl");
                }

                return bookingBaseUrl;
            }
        }

    }
}
