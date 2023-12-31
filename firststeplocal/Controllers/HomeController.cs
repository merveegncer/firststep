﻿using firststeplocal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace firststeplocal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly favoribu_merveContext _favoribu_merveContext;

        public HomeController(ILogger<HomeController> logger,favoribu_merveContext favoribu_merveContext)
        {
            _logger = logger;
            this._favoribu_merveContext = favoribu_merveContext;
        }

        public IActionResult Index()
        {
            var test = _favoribu_merveContext.Genders.First();
            return View(test);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

