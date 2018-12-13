using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using HtmlAgilityPack;


namespace DemoCnBlogs
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("http://www.cnblogs.com/pick/");

            HtmlNode node = doc.GetElementbyId("post_list");

            StreamWriter sw = File.CreateText("log.txt");

            foreach (HtmlNode child in node.ChildNodes)
            {
                if (child.Attributes["class"] == null || child.Attributes["class"].Value != "post_item")
                    continue;
                HtmlNode hn = HtmlNode.CreateNode(child.OuterHtml);

                ///如果用child.SelectSingleNode("//*[@class=\"titlelnk\"]").InnerText这样的方式查询，是永远以整个document为基准来查询，
                ///这点就不好，理应以当前child节点的html为基准才对。

                Write(sw, String.Format("推荐：{0}", hn.SelectSingleNode("//*[@class=\"diggnum\"]").InnerText));
                Write(sw, String.Format("标题：{0}", hn.SelectSingleNode("//*[@class=\"titlelnk\"]").InnerText));
                Write(sw, String.Format("介绍：{0}", hn.SelectSingleNode("//*[@class=\"post_item_summary\"]").InnerText));
                Write(sw, String.Format("信息：{0}", hn.SelectSingleNode("//*[@class=\"post_item_foot\"]").InnerText));

                Write(sw, "----------------------------------------");

            }

            sw.Close();

            Console.ReadLine();
        }

        static void Write(StreamWriter writer, string str)
        {
            Console.WriteLine(str);
            writer.WriteLine(str);
        }


    }
}