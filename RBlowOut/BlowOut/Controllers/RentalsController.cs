using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{ 
    public class RentalsController : Controller
    {
        public  static string Usedd;
        public  static string Neww;
        public static string Instrument;
        public static string bottle;

        public static int iCount; 

        // GET: Rentals
        public ActionResult Rentals()
        {
            return View();
        }

        public ActionResult Trumpet()
        {
            Instrument = "Trumpet";
            Usedd = "$25";
            Neww = "$55";
            ViewBag.Used = Usedd;
            ViewBag.New = Neww;
            ViewBag.Instrument = Instrument;
            return View("Instrument");
        }
        public ActionResult Trombone()
        {
            Instrument = "Trombone";
            Usedd = "$35";
            Neww = "$60";
            ViewBag.Instrument = Instrument;
            return View("Instrument");
        }
        public ActionResult Tuba()
        {
            Instrument = "Tuba";
            Usedd = "$50";
            Neww = "$70";
            ViewBag.Instrument = Instrument;
            return View("Instrument");
        }
        public ActionResult Flute()
        {
            Instrument = "Flute";
            Usedd = "$25";
            Neww = "$40";
            ViewBag.Instrument = Instrument;
            return View("Instrument");
        }
        public ActionResult Clarinet()
        {
            Instrument = "Clarinet";
            Usedd = "$27";
            Neww = "$35";
            ViewBag.Instrument = Instrument;
            return View("Instrument");
        }
        public ActionResult Saxophone()
        {
            Instrument = "Saxophone";
            Usedd = "$30";
            Neww = "$42";
            ViewBag.Instrument = Instrument;
            return View("Instrument");
        }

        public ActionResult New()
        {
            bottle = "To rent a new "+ Instrument+ " will cost ";
            ViewBag.New = bottle + Neww;
             return View();
        }

        public ActionResult Used()
        {
            bottle = "To rent a used " + Instrument + " will cost ";
            ViewBag.Used = bottle + Usedd;
            return View();

           
        }
    }
}