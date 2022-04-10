using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pr_cr_crud.db_context;
using pr_cr_crud.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace pr_cr_crud.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            shopContext DB = new shopContext();
            var data=DB.Productdtls.ToList();
            DB.SaveChanges();
            return View(data);
        }

        public IActionResult Privacy()
        {
            shopContext DB = new shopContext();
            var data=DB.Owners.ToList();
            

            return View(data);
        }

        public ActionResult Delete(int id)
        {
            shopContext DB = new shopContext();
            var dateledata = DB.Productdtls.Where(m=>m.PrdctNo == id).First();
            DB.Productdtls.Remove(dateledata);
            DB.SaveChanges();




            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
