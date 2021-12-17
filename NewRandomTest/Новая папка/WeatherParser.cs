using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NewRandomTest
{
    public class WeatherParser
    {
        public static string ParserWeather(string txtHTML, string txtPrefix, string txtSuffix)
        {
            var prefixPosition = txtHTML.IndexOf(txtPrefix, StringComparison.OrdinalIgnoreCase);
            var suffixPosition = txtHTML.IndexOf(txtSuffix, prefixPosition + txtPrefix.Length, StringComparison.OrdinalIgnoreCase);
            if ((prefixPosition >= 0) && (suffixPosition >= 0) && (suffixPosition > prefixPosition) && ((prefixPosition + txtPrefix.Length) <= suffixPosition))
            {
                return txtHTML.Substring(prefixPosition + txtPrefix.Length +20 , suffixPosition - prefixPosition - txtPrefix.Length -25);
            }
            else
            {
                return "Error";
            }

        }
        public static string Weather()
        {
            WebClient wc = new WebClient();
            string HTML = wc.DownloadString("https://ru-meteo.ru/moscow/hour");
            string prefix = @"<span class=""apparent"">";
            string suffix = @"</span>";
            //<span class="t0">0°</span>
            string Weather = ParserWeather(HTML, prefix, suffix);
            return Weather;
        }
    }
}
