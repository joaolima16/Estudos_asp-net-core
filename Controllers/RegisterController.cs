using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using login_registro_asp.Data;
using login_registro_asp.Models;
using login_registro_asp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace login_registro_asp.Controllers
{
    public class Register : Controller
    {

        private IUser _IUser;

         public Register(IUser IUser) => _IUser = IUser;

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        [HttpPost]
        public IActionResult RegisterUser(UserModel user)
        {
            _IUser.Add(user);
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}