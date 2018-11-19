using HtmlAgilityPack;
using System;

namespace ConsolePractice
{
    class Program
    {
        public class SendShortMessageRequest
        {
            public string Mobile { get; set; }
            public string 汉字的 { get; set; }
            public string ToAddress { get; set; }
            public string MsgTime { get; set; }
        }

        //static void Main()
        //{
        //    using (var _context = new ConsolePracticeContext())
        //    {
        //        var company = new Company
        //        {
        //            Contact = "",
        //            ContactMoblie = "",
        //            Name = ""
        //        };
        //        _context.Company.Add(company);
        //        _context.SaveChanges();
        //    }
        //}
        //static void Main(string[] args) => IsLeapYear.Run().Wait();

        static void Main()
        {
            try
            {
                string html = Crawler.DownloadHtml(@"http://www.jd.com/allSort.aspx");
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);
                string goodClass = @"//*[@class='items']/dl/dd";
                HtmlNodeCollection noneNodeList = doc.DocumentNode.SelectNodes(goodClass);
                foreach (var node in noneNodeList)
                {
                    HtmlDocument docChild = new HtmlDocument();
                    docChild.LoadHtml(node.OuterHtml);
                    string urlPath = "/dd/a";
                    HtmlNodeCollection list = docChild.DocumentNode.SelectNodes(urlPath);
                    foreach (var l in list)
                    {
                        HtmlDocument docChild1 = new HtmlDocument();
                        docChild1.LoadHtml(l.OuterHtml);
                        var sortUrl = l.Attributes["href"].Value;
                        if (!string.IsNullOrWhiteSpace(sortUrl) && sortUrl.Contains("cat="))
                        {
                            InsertSort("https:" + sortUrl);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
