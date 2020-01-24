using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            List<Phone> PhoneList = new List<Phone>
            {
               new Phone{ PhoneID = 0001,PhoneName = "iAmBad", Manufacturer = "Pear", msrp = 999.99,ScreenSize = "5.8 inch", DateReleased = DateTime.Parse("03/11/2017") },
               new Phone{ PhoneID = 0002,PhoneName = "Solar System Notation 8", Manufacturer = "Samuelsings", msrp = 274.99,ScreenSize = "6.3 inch", DateReleased = DateTime.Parse("23/07/2017") },
               new Phone{ PhoneID = 0003,PhoneName = "Noodle Bit 4", Manufacturer = "Noodle", msrp = 1259.99,ScreenSize = "6.3 inch", DateReleased = DateTime.Parse("24/10/2019") }
            };
            return View(PhoneList);
        }
    }
}