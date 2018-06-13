﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Template.Dev.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : DevControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}