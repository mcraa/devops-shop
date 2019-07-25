using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GiftShop.Models;
using Microsoft.Extensions.Options;

namespace GiftShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly OptionsModel build;

        public HomeController(IOptions<OptionsModel> build)
        {
            this.build = build.Value;
        }
        public IActionResult Index()
        {
            return Ok(new { buildNumber = build.BuildNumber, name = build.RequestedForEmail });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
