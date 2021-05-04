using LizokasNail.Site.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LizokasNail.Site.Controllers
{
    public class BaseController : MainController
    {
        public async Task<IActionResult> Index()
        {
            var allBases = await BaseRepo.GetList();
            return View(allBases);
        }
    }
}
