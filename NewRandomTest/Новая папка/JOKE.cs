using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NewRandomTest.Новая_папка
{
    class JOKE
    { 
        public async void JOKEparse()
        {
            string site = "https://panorama.pub";
            WebRequest NewsListRequest = WebRequest.Create(site);
            using WebResponse NewsListResponse = await NewsListRequest.GetResponseAsync();
            using Stream stream = NewsListResponse.GetResponseStream();
            HtmlDocument document = new HtmlDocument();
            document.Load(stream);

            var NewsNodes = document.DocumentNode.SelectNodes("//a[contains(@class, 'entry big')]");

            
        }
        
    }
}
