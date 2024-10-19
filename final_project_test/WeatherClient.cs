using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace final_project_test
{
    public class WeatherClient
    {
        // weather setting
        public static bool KeepAlive = false;  // true is keep connecting
        public static int Timeout = 10000;  // initial timeout = 10s

        public static string HttpGet(string url)
        {
            return WeatherClient.HttpGet(url, Encoding.Default);
        }

        public static string HttpGet(string url, Encoding encoding)
        {
            string result = "";
            Uri uri = new Uri(url);
            HttpWebRequest hwReq = WebRequest.Create(uri) as HttpWebRequest;

            hwReq.Method = WebRequestMethods.Http.Get;
            hwReq.KeepAlive = KeepAlive;
            hwReq.Timeout = Timeout;

            using(HttpWebResponse hwRes = hwReq.GetResponse() as HttpWebResponse)
            {
                using(StreamReader sr = new StreamReader(hwRes.GetResponseStream(), encoding))
                {
                    result = sr.ReadToEnd();
                }
            }

            return result;
        }

        public static string HttpPost(string url, Dictionary<string, string> postData)
        {
            return WeatherClient.HttpPost(url, postData, Encoding.Default);
        }

        public static string HttpPost(string url, Dictionary<string, string> postData, Encoding encoding)
        {
            string ret = "";
            Uri uri = new Uri(url);
            HttpWebRequest hwReq = WebRequest.Create(uri) as HttpWebRequest;

            hwReq.Method = WebRequestMethods.Http.Post;
            hwReq.KeepAlive = KeepAlive;
            hwReq.Timeout = Timeout;
            hwReq.ContentType = "application/x-www--form--urlencoded";

            StringBuilder data = new StringBuilder();
            string ampersand = "";
            foreach(string key in postData.Keys)
            {
                data.Append(ampersand).Append(key).Append("=").Append(HttpUtility.UrlEncode(postData[key]));
                ampersand = "&";
            }

            byte[] byteData = UTF8Encoding.UTF8.GetBytes(data.ToString());

            // setting writing length
            hwReq.ContentLength = byteData.Length;

            // write post parameter 
            using(Stream postStream = hwReq.GetRequestStream())
            {
                postStream.Write(byteData, 0, byteData.Length);
            }

            using(HttpWebResponse hwRes = hwReq.GetResponse() as HttpWebResponse)
            {
                using (StreamReader sr = new StreamReader(hwRes.GetResponseStream(), encoding))
                {
                    ret = sr.ReadToEnd();
                }
            }

            return ret;
        }
    }
}
