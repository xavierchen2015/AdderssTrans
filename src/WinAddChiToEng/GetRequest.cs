namespace WinAddChiToEng
{
    using System;
    using System.Collections.Generic;
    using System.Web;
    using SimpleLogging.Core;

    public class GetRequest
    {
        private static Dictionary<string, string> road = new Dictionary<string, string>
        {
            { "一段", "1段" }, { "二段", "2段" }, { "三段", "3段" }, { "四段", "4段" }, { "五段", "5段" },
            { "六段", "6段" }, { "七段", "7段" }, { "八段", "8段" }, { "九段", "9段" }, { "十段", "10段" }
        };

        private readonly ILoggingService log;

        public GetRequest(ILoggingService logService)
        {
            this.log = logService;
        }

        public string GetAddress(string city, string cityarea, string street, string lane, string alley, string num, string num_hyphen, string fl, string hyphen, string suite)
        {
            city = this.CheckStrFormat(city, "city");
            street = this.CheckStrFormat(street, "street");

            string param = "do_s_1=1&city=" + HttpUtility.UrlEncode(city) + "&change_city=2&cityarea=" + HttpUtility.UrlEncode(cityarea) + "&street=" + HttpUtility.UrlEncode(street) + "&lane=" + HttpUtility.UrlEncode(lane) + "&alley=" + HttpUtility.UrlEncode(alley) + "&num=" + HttpUtility.UrlEncode(num) + "&num_hyphen=" + HttpUtility.UrlEncode(num_hyphen) + "&fl=" + HttpUtility.UrlEncode(fl) + "&hyphen=" + HttpUtility.UrlEncode(hyphen) + "&suite=" + HttpUtility.UrlEncode(suite) + "&list=true&submit=%E6%9F%A5%E8%A9%A2";
            var httpproxy = new HttpFun(this.log);
            string result = httpproxy.GetHtml(param);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(result);
            HtmlAgilityPack.HtmlNode docTable = doc.DocumentNode.SelectSingleNode("//table [@id=\"tb1\"]");

            HtmlAgilityPack.HtmlDocument tableHtml = new HtmlAgilityPack.HtmlDocument();
            tableHtml.LoadHtml(docTable.InnerHtml);
            HtmlAgilityPack.HtmlNode docTd = doc.DocumentNode.SelectSingleNode("//td");

            this.log.Info("Adderss : {0}", docTd.InnerText);
            return docTd.InnerText;
        }

        private string CheckStrFormat(string str, string type)
        {
            switch (type)
            {
                case "city":
                    str = str.Replace("台", "臺");
                    break;
                case "street":
                    foreach (var n in road)
                    {
                        if (str.IndexOf(n.Key) > 0)
                        {
                            str = str.Replace(n.Key, n.Value);
                        }
                    }

                    break;
            }

            return str;
        }
    }
}
