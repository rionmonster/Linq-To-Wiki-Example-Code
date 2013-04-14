using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LinqToWiki.Generated;
using Linq_To_Wiki_Example.Models;

namespace Linq_To_Wiki_Example.Controllers
{
    public class WikiController : Controller
    {
        public ActionResult Index()
        {
            //Creates a new Wiki object to query Wikipedia
            var wikipedia = new Wiki("Example");

            //This query pulls all images that begin with "Microsoft"
            var query = wikipedia.Query.allimages()
                        .Where(i => i.prefix == "Microsoft")
                        .Select(s => new WikiImage(s.url, s.height, s.width)).ToList();
            return View(query);
        }
    }
}