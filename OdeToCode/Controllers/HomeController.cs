﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OdeToCode.Data;
using OdeToCode.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace OdeToCode.Controllers
{
	public class HomeController : Controller
	{
		private readonly ApplicationDbContext _db;

		public HomeController(ApplicationDbContext dbContext)
		{
			_db = dbContext;
		}

		public IActionResult Index()
		{
			var model = _db.Restaurants.ToList();
			return View(model);
		}

		public IActionResult Privacy()
		{
			return View();
		}
		public IActionResult About()
		{
			var model = new AboutModel();
			model.Name = "Kristjan";
			model.Location = "Tallinn, Estonia";
			return View(model);
		}
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
		protected override void Dispose(bool disposing)
		{
			if (_db != null)
			{
				_db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}