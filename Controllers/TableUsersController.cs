using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using login_registro_asp.Models;
using login_registro_asp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace login_registro_asp.Controllers
{
    public class TableUsers : Controller
    {
        public IUser _IUser;
        public TableUsers(IUser IUser) => _IUser = IUser;

        private readonly ILogger<TableUsers> _logger;

        [HttpGet]
        public IActionResult Index()
        {
            List<UserModel> lstUsers = _IUser.lstUsers();
            
             return View(lstUsers);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}