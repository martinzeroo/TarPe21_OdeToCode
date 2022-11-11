using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
		public const string ROLE_ADMIN = "Admin";
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
					new Restaurant { Name = "Smaka", City = "Gothenburg", Country = "Sweden" });

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

		internal static void SeedIdentity(UserManager<OdeToCodeUser> userManager, RoleManager<OdeToCodeRole> roleManager)
		{
            var user = userManager.FindByNameAsync("martin@thk.ee").Result;
            if (user == null)
            {
                user.Email = "martin@thk.ee";
                user.EmailConfirmed = true;
                user.UserName = "martin@thk.ee";
                IdentityResult result = new userManager.CreateAsync(user).Result;
                if (result.Succeeded)
                {
                    user.PasswordHash = userManager.PasswordHasher.HashPassword(user, "1234");
                    var _ = userManager.UpdateAsync(user).Result;
                }
                else
                {
                    throw new Exception($"User creation faield: {result.Errors.FirstOrDefault()}");
                }
            }
            var role = roleManager.FindByNameAsync("Admin").Result;
            if (role == null)
            {
                role = new IdentityRole("Admin");
                RoleManager result = roleManager.CreateAsync(role).Result;
                if (result.Succeeded)
                {

                }
            }
        }
	}
}