using BookmyMovie.Interface;
using BookmyMovie.Models;
using BookmyMovie.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookmyMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        mymovieDBContext db;
        IJWTMangerRepository iJWTMangerRepository;
        public loginController(mymovieDBContext _db, IJWTMangerRepository _iJWTMangerRepository)
        {
            db = _db;
            iJWTMangerRepository = _iJWTMangerRepository;
        }



        [HttpPost]
        [Route("login")]
        public IActionResult Login(loginViewModels loginViewModel)
        {
            var token = iJWTMangerRepository.Authenicate(loginViewModel, false);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            loginViewModels login = new loginViewModels();
            login.UserName = registerViewModel.UserName;
            login.Password = registerViewModel.Password;
            var token = iJWTMangerRepository.Authenicate(login, true);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}
