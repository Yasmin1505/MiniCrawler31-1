using Display050116.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;//
using System.Web;
using System.Web.Mvc;

namespace Display050116.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetData(string txtUrl, string rbGroup)
        {
            if(rbGroup == "Images")
            {
                var picsColl = PictureCollectionMethods.ExtractPictures(txtUrl);
                return View("PictureDisplayer", picsColl);
            }
            else if(rbGroup == "Links")
            {
                var linksColl = LinksCollectionMethods.ExtractLinks(txtUrl);
                return View("LinkDisplayer", linksColl);
            }
            return View(); //Some Default page
        }

        [HttpGet]
        public ActionResult SurpriseMe()
        {
            string urlStr = Surprise.GetSurprise();
            List<Picture> surpriseColl = PictureCollectionMethods.ExtractPictures(urlStr);
            return View("SurpriseDisplayer", surpriseColl);
        }
        public string ActionFromAjax()
        {
            return "You Clicked ME!! You Clicked Me!";
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}