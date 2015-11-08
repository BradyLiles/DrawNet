using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawNet.Core.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DrawNet.Core
{
    public class Class1 : IdentityUser
    {
        public static void test()
        {
            var ctx = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>());

            if (!roleManager.RoleExists("Draw Company"))
            {
                roleManager.Create(new IdentityRole { Name = "Draw Company" });
            }

            if (!roleManager.RoleExists("Inspection Services"))
            {
                roleManager.Create(new IdentityRole { Name = "Inspection Services" });
            }

            if (!roleManager.RoleExists("Property Services"))
            {
                roleManager.Create(new IdentityRole { Name = "Property Services" });
            }

            if (!roleManager.RoleExists("Inspector"))
            {
                roleManager.Create(new IdentityRole { Name = "Inspector" });
            }

            if (!roleManager.RoleExists("Loan Officer"))
            {
                roleManager.Create(new IdentityRole { Name = "Loan Officer" });
            }

            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);

            manager.Create(new IdentityUser() { UserName = "DrawCompany@drawnet.com" }, "Password");

            manager.Create(new IdentityUser() { UserName = "Inspector@drawnet.com" }, "Password");

            manager.Create(new IdentityUser() { UserName = "LoanOfficer@drawnet.com" }, "Password");


            var drawCompany = manager.FindByName("DrawCompany@drawnet.com");
            manager.AddToRole(drawCompany.Id, "Inspection Services");
            manager.AddToRole(drawCompany.Id, "Draw Company");

            var inspector = manager.FindByName("Inspector@drawnet.com");
            manager.AddToRole(inspector.Id, "Inspection Services");
            manager.AddToRole(inspector.Id, "Inspector");

            var loanOfficer = manager.FindByName("LoanOfficer@drawnet.com");
            manager.AddToRole(loanOfficer.Id, "Property Services");
            manager.AddToRole(loanOfficer.Id, "Loan Officer");

            ctx.SaveChanges();

        }
    }
}
