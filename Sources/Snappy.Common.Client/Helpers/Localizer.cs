using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Snappy.Common.Client.Helpers
{
    public static class Localizer
    {
        public static string Localize(this HtmlHelper helper, string key)
        {
            try
            {
                var text = key;// ((Dictionary<string, string>)Context.Application[Thread.CurrentThread.CurrentUICulture.Name])[key];
                return string.IsNullOrEmpty(text) ? key : text;
            }
            catch { return key; }
        }

        public static string Localize(string key)
        {
            return Localize(null, key);
        }
    }
}