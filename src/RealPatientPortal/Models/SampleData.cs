using System;
using System.Linq;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RealPatientPortal.Models
{
    public class SampleData
    {
        public async static Task Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();
            var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
            context.Database.Migrate();

            // Ensure John (IsAdmin)
            var john = await userManager.FindByNameAsync("drjohndoe@email.com");
            if (john == null)
            {
                // create user
                john = new Doctor
                {
                    FirstName = "John",
                    LastName = "Doe",
                    UserName = "drjohndoe@email.com",
                    Email = "drjohndoe@email.com",
                    Specialty = "Primary Care Physician"
                };
                await userManager.CreateAsync(john, "drJohnDoe123!");

                // add claims
                await userManager.AddClaimAsync(john, new Claim("IsAdmin", "true"));
            }

            // Ensure Jane (IsAdmin)
            var jane = await userManager.FindByNameAsync("drjanejohnson@email.com");
            if (jane == null)
            {
                // create user
                jane = new Doctor
                {
                    FirstName = "Jane",
                    LastName = "Johnson",
                    UserName = "drjanejohnson@email.com",
                    Email = "drjanejohnson@email.com",
                    Specialty = "Cardiologist"
                };
                await userManager.CreateAsync(jane, "drJaneJohnson123!");

                // add claims
                await userManager.AddClaimAsync(jane, new Claim("IsAdmin", "true"));
            }

            // Ensure Jennifer (IsAdmin)
            var jennifer = await userManager.FindByNameAsync("drjenniferjones@email.com");
            if (jennifer == null)
            {
                // create user
                jennifer = new Doctor
                {
                    FirstName = "Jennifer",
                    LastName = "Jones",
                    UserName = "drjenniferjones@email.com",
                    Email = "drjenniferjones@email.com",
                    Specialty = "ObGyn"
                };
                await userManager.CreateAsync(jennifer, "drJenniferJones123!");

                // add claims
                await userManager.AddClaimAsync(jennifer, new Claim("IsAdmin", "true"));
            }


        }

    }
}
