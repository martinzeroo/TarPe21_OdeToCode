﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OdeToCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToCode.Data
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
			{
				if (context.Restaurants.Any())
				{
					return;
				}
				context.Restaurants.AddRange(
					new Restaurant { Name = "Sabatino's", City = "Baltimore", Country = "USA" },
					new Restaurant { Name = "Great Lake", City = "Chicago", Country = "USA" },
					new Restaurant { Name = "Smaka", City = "Gothenburg", Country = "Sweden", Reviews = new List<RestaurantReview> { new RestaurantReview { Rating = 9, Body = "Great food!" } } });

				for (int i = 0; i < 1000; i++)
				{
					context.Restaurants.AddRange(
					new Restaurant
					{
						Name = $"{i}",
						City = "Nowhere",
						Country = "USA"
					});
				}
				context.SaveChanges();
			}
		}
	}
}