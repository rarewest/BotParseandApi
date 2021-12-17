using System;
using System.Net;

namespace NewRandomTest
{
    public class XRPParser
    {
        public static string ParserXRP(string txtHTML, string txtPrefix, string txtSuffix)
        {
            var prefixPosition = txtHTML.IndexOf(txtPrefix, StringComparison.OrdinalIgnoreCase);
            var suffixPosition = txtHTML.IndexOf(txtSuffix, prefixPosition + txtPrefix.Length, StringComparison.OrdinalIgnoreCase);
            if ((prefixPosition >= 0) && (suffixPosition >= 0) && (suffixPosition > prefixPosition) && ((prefixPosition + txtPrefix.Length) <= suffixPosition))
            {
                return txtHTML.Substring(prefixPosition + txtPrefix.Length + 1, suffixPosition - prefixPosition - txtPrefix.Length - 2);
            }
            else
            {
                return "Error";
            }

        }
        public static string Xrp()
        {
            WebClient wc = new WebClient();
            string HTML = wc.DownloadString("https://bankiros.ru/crypto/ripple");
            string prefix = @"<div class=""crypto_curr_val"">";
            string suffix = @"</div>";
            string XRP = ParserXRP(HTML, prefix, suffix);
            return XRP;
        }
    }
}
