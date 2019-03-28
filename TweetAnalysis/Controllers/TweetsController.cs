using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TweetAnalysis;

namespace TweetAnalysis.Controllers
{
    public class TweetsController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Tweets
        public ActionResult Index()
        {
            var tweets = db.Tweets.OrderByDescending(o => o.Id).ToList();
            return View(tweets);
        }

        public ActionResult Winner()
        {
            //var tweets = db.Tweets.ToList();
            Random rnd = new Random();
            var tweets = db.Tweets.ToList();
            tweets = tweets.OrderBy(user => rnd.Next()).Take(7).ToList();
            return View("Index", tweets);
        }
    }
}
