using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RetailBank_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailBank_UI.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        public IActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserCred u)
        {

            var v = u.UserId;


            return View();
        }
    }
}
