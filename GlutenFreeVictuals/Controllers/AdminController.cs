﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using GlutenFreeVictuals.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlutenFreeVictuals.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<User> userManager;

        public AdminController(UserManager<User> usrMgr)
        {
            userManager = usrMgr;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(userManager.Users);
        }

        public IActionResult ShowUserAccounts()
        {
            return View(userManager.Users);
        }
    }
}