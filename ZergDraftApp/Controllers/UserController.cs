using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZergDraftApp.Models;

namespace ZergDraftApp.Controllers
{
    public class UserController : Controller
    {
	    public ActionResult SetAsUser()
	    {
			UserProvider.Role = UserRole.User;

		    return new RedirectResult(Request.UrlReferrer.AbsoluteUri);
	    }


	    public ActionResult SetAsAdmin()
	    {
			UserProvider.Role = UserRole.Admin;

			return new RedirectResult(Request.UrlReferrer.AbsoluteUri);
		}


	    public ActionResult Dislogin()
	    {
			UserProvider.Role = UserRole.None;

			return new RedirectResult(Request.UrlReferrer.AbsoluteUri);
		}


	}
}