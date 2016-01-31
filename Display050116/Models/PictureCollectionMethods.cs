using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Display050116.Models
{
    public class PictureCollectionMethods
    {
        public static List<Picture> ExtractPictures(string url)
        {
            int maxPics = 10; //later will be set by user
            int counterPics =0;
            List<Picture> picCollection = new List<Picture>();
            WebClient client = new WebClient(); //Faster download with WebClient
            string htmlStr = client.DownloadString(new Uri(url));
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(htmlStr);
            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//img[@src]"))
            {
                if (counterPics < maxPics)
                {
                    picCollection.Add(new Picture() { PicUrl = node.Attributes["src"].Value, Name = node.Name });
                    counterPics++;
                }
                else break;
            }
            return picCollection;
        }
    }
}