using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WordHive.Controllers
{
    public class PuzzleController : Controller
    {
        // GET: Puzzle
        public ActionResult Index()
        {
            return View();
        }
    }
}