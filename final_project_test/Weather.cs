using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Xml;

namespace final_project_test
{

    public class WeatherData : IEquatable<WeatherData>
    {
        public string location { get; set; }
        public string wx { get; set; }
        public string poP { get; set; }
        public string temperature { get; set; }
        public string ci { get; set; }
        public string wind { get; set; }
        public string rh { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            WeatherData objAsWeatherData = obj as WeatherData;
            if (objAsWeatherData == null) return false;
            else return Equals(objAsWeatherData);
        }

        public bool Equals(WeatherData other)
        {
            if (other == null) return false;
            return (this.location.Equals(other.location));
        }

        public override int GetHashCode()
        {
            return new {location, wx, poP, temperature, ci, wind, rh}.GetHashCode();
        }
    }

    public class Weather
    {
        private static string location;
        private static string wx;
        private static string poP;
        private static string temperature;
        private static string ci;
        private static string wind;
        private static string rh;

        private static string apikey = string.Empty;

        private static List<WeatherData> wdList = new List<WeatherData>();
        private static List<string> locations = new List<string>();

        public string Location { get => location; set => location = value; }
        public string Wx {  get => wx = wdList.Find(wd => wd.location.Equals(location)).wx; }
        public string PoP { get => poP = wdList.Find(wd => wd.location.Equals(location)).poP; }
        public string Temperature { get => temperature = wdList.Find(wd => wd.location.Equals(location)).temperature; }
        public string CI { get => ci = wdList.Find(wd => wd.location.Equals(location)).ci; }
        public string Wind {  get => wind = wdList.Find(wd => wd.location.Equals(location)).wind; }
        public string RH { get => rh = wdList.Find(wd => wd.location.Equals(location)).rh; }
        public List<string> Locations { get => locations; }

        public Weather()
        {
            string path = @"apikey.txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    apikey = sr.ReadLine();
                }
            }
            else
            {
                Debug.WriteLine("not found apikey");
            }

        }

        public bool getCityData(string city)
        {
            string dataid;

            switch (city)
            {
                case "臺南市":
                    dataid = "F-D0047-077";
                    break;
                case "宜蘭縣":
                    dataid = "F-D0047-001";
                    break;
                case "桃園市":
                    dataid = "F-D0047-005";
                    break;
                case "新竹縣":
                    dataid = "F-D0047-009";
                    break;
                case "新竹市":
                    dataid = "F-D0047-053";
                    break;
                case "苗栗縣":
                    dataid = "F-D0047-013";
                    break;
                case "彰化縣":
                    dataid = "F-D0047-017";
                    break;
                case "南投縣":
                    dataid = "F-D0047-021";
                    break;
                case "雲林縣":
                    dataid = "F-D0047-025";
                    break;
                case "嘉義縣":
                    dataid = "F-D0047-029";
                    break;
                case "嘉義市":
                    dataid = "F-D0047-057";
                    break;
                case "屏東縣":
                    dataid = "F-D0047-033";
                    break;
                case "臺東縣":
                    dataid = "F-D0047-037";
                    break;
                case "花蓮縣":
                    dataid = "F-D0047-041";
                    break;
                case "澎湖縣":
                    dataid = "F-D0047-045";
                    break;
                case "基隆市":
                    dataid = "F-D0047-049";
                    break;
                case "臺北市":
                    dataid = "F-D0047-061";
                    break;
                case "新北市":
                    dataid = "F-D0047-069";
                    break;
                case "高雄市":
                    dataid = "F-D0047-065";
                    break;
                case "臺中市":
                    dataid = "F-D0047-073";
                    break;
                case "連江縣":
                    dataid = "F-D0047-081";
                    break;
                case "金門縣":
                    dataid = "F-D0047-085";
                    break;
                default:
                    return false;
            }

            Debug.WriteLine("getting data......");
            try
            {
                string str_Xml = WeatherClient.HttpGet(
                    getWeatherApi(dataid, apikey, "XML"),
                    Encoding.UTF8);

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(str_Xml);

                XmlNodeList xnList = xml.SelectNodes("/dataset/records/locations/location");
                wdList.Clear();
                locations.Clear();
                foreach (XmlNode xn in xnList)
                {
                    WeatherData wd = new WeatherData();
                    wd.location = xn["locationName"].InnerText;
                    locations.Add(wd.location);
                    XmlNode xnEV = xn.SelectSingleNode("weatherElement/time");
                    string weatherDescription = xnEV["elementValue"]["value"].InnerText;
                    string[] wDes = weatherDescription.Split('。');
                    wd.wx = wDes[0];
                    wd.poP = wDes[1];
                    wd.temperature = wDes[2];
                    wd.ci = wDes[3];
                    wd.wind = wDes[4];
                    wd.rh = wDes[5];

                    wdList.Add(wd);
                }

                // initial weather data with first result
                location = wdList[0].location;

                if (wdList.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }catch(Exception ex)
            {
                Debug.WriteLine("get City Data error:");
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public static string getWeatherApi(string dataid, string apikey, string format)
        {
            return string.Format("https://opendata.cwa.gov.tw/api/v1/rest/datastore/{0}?Authorization={1}&format={2}&elementName=WeatherDescription", dataid, apikey, format);
        }
    }
}
