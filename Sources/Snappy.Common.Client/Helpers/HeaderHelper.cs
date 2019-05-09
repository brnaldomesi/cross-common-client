namespace Snappy.Common.Client.Helpers
{
    public class HeaderHelper
    {
        public const string HEADER_X_IP = "X-IP";

        /// <summary>
        /// 3 letter country code header
        /// supplied from NGINX GEOIP2 module
        /// </summary>
        public const string HEADER_X_COUNTRY = "X-COUNTRY";
        public const string HEADER_X_CITY = "X-CITY";
    }
}