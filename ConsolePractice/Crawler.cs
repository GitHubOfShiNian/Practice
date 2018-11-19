using System;
using System.IO;
using System.Net;
using System.Text;

namespace ConsolePractice
{
    public class Crawler
    {

        public static string DownloadHtml(string url, Encoding encode)
        {
            string html = string.Empty;
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Timeout = 30 * 1000;
                request.UserAgent = "Mozilla/5.0(Windows NT 10.0; WOW64) AppleWebKit/537.36(KHTMK,like Gecko) Chrome/51.0.2704.106 Safari/537.36";
                request.ContentType = "text/html; charset=utf-8";
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        try
                        {
                            StreamReader str = new StreamReader(response.GetResponseStream(), encode);
                            html = str.ReadToEnd();
                            str.Close();
                        }
                        catch (Exception ex)
                        {
                            html = null;
                        }
                    }
                }
            }
            catch (System.Net.WebException ex)
            {
                html = null;
            }
            catch (Exception ex)
            {
                html = null;
            }
            return html;
        }
    }
}
