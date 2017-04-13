using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZergDraftApp.Controllers
{
	public enum Region
	{
		US,
		EU,
		KR,
		TW,
		CN,
	}

    public class TmpController : Controller
    {
        public ActionResult Index()
        {
	        const string client_id = "z5edv6uya2cqsmj8qzsp5udmh9p2chk8";
	        const string client_secret = "74GdDMpVeZ46h6SyRwjcjYCZxXvuQXkm";
	        const string AuthorizeUrlTemplate = "https://<{0}>.battle.net/oauth/authorize";

	        const Region region = Region.EU;



			return new EmptyResult();
        }
    }
}