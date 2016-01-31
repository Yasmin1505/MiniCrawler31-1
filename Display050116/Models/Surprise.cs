using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Display050116.Models
{
    public static class Surprise
    {
        public static string GetSurprise()
        {
             Dictionary<int,string> IdToSite = new Dictionary<int,string>(){
            {1,"http://wired.com"},
            {2,"http://www.nationalgeographic.com/"},
            {3,"https://www.ted.com/"},
            {4,"https://www.padi.com/scuba-diving/"}
        };
            Random rnd = new Random();
            int rndKey = rnd.Next(1, 5);
            return IdToSite.FirstOrDefault(x => x.Key == rndKey).Value;
        }
    }
}