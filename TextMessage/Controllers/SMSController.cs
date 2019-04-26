using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TextMessage.Models;

namespace TextMessage.Controllers
{
    public class SMSController : Controller
    {
        // GET: SMS
        public ActionResult SentMessage(Message msg)
        {
            return View(msg);
        }


        // GET: SMS/Create
        public ActionResult SendMessage()
        {
            return View();
        }

        // POST: SMS/Create
        [HttpPost]
        public ActionResult SendMessage(Message msg)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("SentMessage", msg);
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(500, ex.Message);
            }
        }

    
    }
}
