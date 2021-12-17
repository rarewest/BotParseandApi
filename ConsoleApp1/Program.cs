using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Text;
using System.Data;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {



        static void Main(string[] args)
        {


            public static HttpWebRequest myReq =
                (HttpWebRequest)WebRequest.Create("http://www.vtb24.ru/");
                public static WebResponse response = myReq.GetResponse();
                public static StreamReader stream = new StreamReader(response.GetResponseStream());
                string s = stream.ReadToEnd();









        }


    }
}
