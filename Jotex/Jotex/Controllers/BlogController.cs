﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.Data;

namespace Jotex.Controllers
{
    public class BlogController : Controller
    {
       
     
        public IActionResult Index()
        {
          
            return View();
        }
        public IActionResult Detailed(int id)
        {
            return View();
        }
    }
}