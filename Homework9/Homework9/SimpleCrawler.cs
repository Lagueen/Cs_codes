using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Homework9
{
    class SimpleCrawler
    {
        public Hashtable urls = new Hashtable();
        public int count = 0;
        //static private string startUrl = "";
        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html,current);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
            Console.ReadLine();
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html,string preUrl)
        {
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'](http|https)[^""'#>]+..html.*?[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                var url = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (url.Length == 0) continue;
                if (url.Contains("https://www.cnblogs.com"))
                {
                    if (urls[url] == null)
                        urls[url] = false;
                }
            }
            strRef = @"(href|HREF)[ ]*=[ ]*[""'][^(http|https)][^""'#>]+..html.*?[""']";
            matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                var url = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (url.Length == 0) continue;
                Uri baseUri = new Uri(preUrl);
                Uri absoluteUri = new Uri(baseUri, url);
                Console.WriteLine("相对路径:" + url);
                Console.WriteLine("绝对路径:" + absoluteUri.ToString());
                if (urls[absoluteUri.ToString()] == null)
                    urls[absoluteUri.ToString()] = false;
            }
        }
    }
}
