using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jotex.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ContactUsViewModel model)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View();
        }


    }
}