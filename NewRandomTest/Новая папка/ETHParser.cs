using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NewRandomTest
{
    public class ETHParser
    {
        public static string ETHParse(string txtHTML, string txtPrefix, string txtSuffix)
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
        public static string Eth()
        {
            WebClient wc = new WebClient();
            string HTML = wc.DownloadString("https://bankiros.ru/crypto/ethereum");
            string prefix = @"<div class=""crypto_curr_val"">";
            string suffix = @"</div>";
            string ETH = ETHParse(HTML, prefix, suffix);
            return ETH;
        }
    }
}
