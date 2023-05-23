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
    public class Login : Controller
    {
        private IUser _IUser;

        public Login(IUser IUser) => _IUser = IUser;

        private readonly ILogger<Login> _logger;
        public async Task OnGetAsync(){
  
        }
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public IActionResult listUsers(UserModel user){


                List<UserModel> userLst = _IUser.SelectUsers(user);

                bool userExists = userLst.Any();
                if(userExists ==true)
                {
                    Console.WriteLine("Usuário encontrado");
                }
                else{

                    Console.WriteLine("Usuário não encontrado");
                }
                return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}