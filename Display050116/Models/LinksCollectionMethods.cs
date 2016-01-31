using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Display050116.Models
{
    public class LinksCollectionMethods
    {
        public static List<string> ExtractLinks(string url)
        {
            List<string> linksColl = new List<string>();
            WebClient client = new WebClient();
            string htmlString = client.DownloadString(new Uri(url));
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(htmlString);
            foreach (HtmlNode linkNode in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                //some validation that the link is legit...
                linksColl.Add(linkNode.Attributes["href"].Value);
            }
            return linksColl;
        }
    }
}