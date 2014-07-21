using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Spatial.Data;

namespace Spatial.Web.Controllers
{
    public class RolesController : Controller
    {
        public ActionResult Index()
        {
            List<IdentityRole> roles;

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                roles = context.Roles.ToList();
            }

            return View(roles);
        }

        // GET: /Roles/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Roles/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                using(ApplicationDbContext context = new ApplicationDbContext())
                {
                    context.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
                    {
                        Name = collection["RoleName"]
                    });
                    context.SaveChanges();
                }
   
                ViewBag.ResultMessage = "Role created successfully !";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }
}