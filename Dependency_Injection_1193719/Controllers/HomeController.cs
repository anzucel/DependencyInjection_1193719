using Dependency_Injection_1193719.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection_1193719.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingleton _singleton;
        private readonly IMovieStoreService _movieStoreService;
        private readonly IUserService _userService;

        public HomeController(ISingleton singleton, IMovieStoreService movieStoreService, IUserService userService)
        {
            _singleton = singleton;
            _movieStoreService = movieStoreService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            ViewBag.singleton = _singleton; //nombre de tienda
            string[] arrayUsers = _movieStoreService.GetUsers(); // lista de usuarios
            ViewBag.movieStoreService = arrayUsers;
            List<user> listUsers = _userService.GetUsersInfo(arrayUsers); //usuarios y películas
            return View(listUsers);
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
