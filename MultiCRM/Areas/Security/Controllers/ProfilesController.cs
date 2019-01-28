using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiCRM.Areas.Security.Controllers
{
    public class ProfilesController : Controller
    {
        // GET: Security/Profiles
        public ActionResult Index()
        {
            return PartialView("Index");
        }
    }
}