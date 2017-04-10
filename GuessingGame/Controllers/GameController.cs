using GuessingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuessingGame.Controllers
{
    public class GameController : Controller
    {
        public ActionResult Index()
        {
            Session["Answer"] = new Random().Next(1, 10);

            return View();
        }

        [HttpPost]
        public ActionResult Index(GameModel model)
        {
            return View(model);
        }
    }
}