﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkRemainder.Controllers
{
    public class HomeworkController : Controller
    {
        // GET: Homework
        public ActionResult Index()
        {
            return View();
        }
    }
}