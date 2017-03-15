using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLibrary;

namespace Unity___MVC.Controllers
{
    public class DrivingController : Controller
    {
        // GET: Driving
        private IDrivable _drivable;
        public DrivingController(IDrivable drivable)
        {
            _drivable = drivable;
        }

        public ActionResult Index()
        {
            return View(_drivable);
        }
    }
}