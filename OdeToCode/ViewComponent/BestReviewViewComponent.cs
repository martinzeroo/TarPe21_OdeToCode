﻿using Microsoft.AspNetCore.Mvc;
using OdeToCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToCode.ViewComponents
{
    public class BestReviewViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(IList<RestaurantReview> reviews)
        {
            var bestReview = from r in reviews
                             orderby r.Rating descending
                             select r;

            return View(bestReview.First());
        }
    }
}