namespace WinAddChiToEng
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using SimpleLogging.Core;

    public class HttpFun
    {
        private readonly ILoggingService log;

        public HttpFun(ILoggingService logService)
        {
            this.log = logService;
        }

        public string GetHtml(string param)
        {
            try
            {
                string url = "http://www.post.gov.tw/post/internet/Postal/index.jsp?ID=207";
                HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
                string result = null;
                request.Method = "POST";
                request.KeepAlive = true;
                request.ContentType = "application/x-www-form-urlencoded";

                byte[] bs = Encoding.ASCII.GetBytes(param);

                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(bs, 0, bs.Length);
                }

                using (WebResponse response = request.GetResponse())
                {
                    StreamReader sr = new StreamReader(response.GetResponseStream());
                    result = sr.ReadToEnd();
                    sr.Close();
                }

                return result;
            }
            catch (Exception ex)
            {
                this.log.Error("HTTP Response error : {0}", ex.StackTrace);
                return "error";
            }
        }
    }
}
