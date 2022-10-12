﻿//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using OdeToCode.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace OdeToCode.Controllers
//{
//    public class ReviewsController : Controller
//    {
//        // GET: ReviewsController
//        public ActionResult Index()
//        {
//            var model =
//                from r in _reviews
//                orderby r.Country
//                select r;

//            return View(model);
//        }

//        // GET: ReviewsController/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: ReviewsController/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: ReviewsController/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: ReviewsController/Edit/5
//        public ActionResult Edit(int id)
//        {
//            var review = _reviews.Single(r => r.Id == id);
//            return View();
//        }

//        // POST: ReviewsController/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<ActionResult> EditAsync(int id, IFormCollection collection)
//        {

//            try
//            {
//                var review = _reviews.Single(r => r.Id == id);
//                if (await TryUpdateModelAsync(review))
//                {
//                    return RedirectToAction(nameof(Index));
//                }
//                return View(review);
//            }
//            catch
//            {
//                return View();
//            }
//        }
//        // GET: ReviewsController/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: ReviewsController/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        static List<RestaurantReview> _reviews = new List<RestaurantReview>
//        {
//            new RestaurantReview
//            {
//                Id = 1,
//                Name = "Cinnamon Club",
//                City = "London",
//                Country = "United Kingdom",
//                Raiting = 10,
//            },
//            new RestaurantReview
//            {
//                Id = 2,
//                Name = "Marrakesh",
//                City = "D.C",
//                Country = "USA",
//                Raiting = 10,
//            },
//            new RestaurantReview
//            {
//                Id = 3,
//                Name = "The House of Elliot",
//                City = "Ghent",
//                Country = "Belgium",
//                Raiting = 10,
//            }
//        };
//    }
//}