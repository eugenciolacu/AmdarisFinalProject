using System.Linq;
using System.Threading.Tasks;
using AmdarisInternship.Domain.Entities;
using AmdarisInternship.Domain.Entities.Authentication;
using AmdarisInternship.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;

namespace AmdarisInternship.API
{
    public class Seed
    {
        public static async Task SeedUsers(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, AmdarisInternshipContext context )
        {
            if (!await roleManager.RoleExistsAsync(UserRoles.Administrator))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.Administrator));
            if (!await roleManager.RoleExistsAsync(UserRoles.Lecturer))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.Lecturer));
            if (!await roleManager.RoleExistsAsync(UserRoles.Mentor))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.Mentor));
            if (!await roleManager.RoleExistsAsync(UserRoles.Intern))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.Intern));

            if (!userManager.Users.Any())
            {
                var applicationUser = new ApplicationUser()
                {
                    UserName = "admin",
                    Email = "eugenciolacu@gmail.com",
                };

                await userManager.CreateAsync(applicationUser, "Admin@123");

                if (await roleManager.RoleExistsAsync(UserRoles.Administrator))
                {
                    await userManager.AddToRoleAsync(applicationUser, UserRoles.Administrator);
                }

                //if (!context.Users_.Any(x => x.FirstName == "Administrator"))
                //{
                //    var user = new User()
                //    {
                //        FirstName = "Administrator",
                //        LastName = "Administrator",
                //        Email = applicationUser.Email,
                //    };

                //    context.Users_.Add(user);
                //    context.SaveChanges();
                //}

                //var testIntern = new ApplicationUser()
                //{
                //    UserName = "testIntern",
                //    Email = "eugenciolacu@yahoo.com",
                //};

                //await userManager.CreateAsync(testIntern, "Admin@123");

                //if (await roleManager.RoleExistsAsync(UserRoles.Intern))
                //{
                //    await userManager.AddToRoleAsync(testIntern, UserRoles.Intern);
                //}

                //if (!context.Users_.Any(x => x.FirstName == "testIntern"))
                //{
                //    var testInternCopy = new User()
                //    {
                //        FirstName = "testIntern",
                //        LastName = "Intern",
                //        Email = testIntern.Email
                //    };

                //    context.Users_.Add(testInternCopy);
                //    context.SaveChanges();
                //}

            }  
        }
    }
}
