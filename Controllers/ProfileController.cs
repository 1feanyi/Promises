using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Promises.Models;

namespace Promises.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Profile model)
        {
            return View();
        }

        public IActionResult Edit(string id)
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

    }
}