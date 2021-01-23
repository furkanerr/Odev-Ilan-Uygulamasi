#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Ödev.BLL.Abstract;
using Ödev.Entities.Concretee;
using ÖdevUI.ExtensionMethods;
using ÖdevUI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace ÖdevUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        private ICityService _cityService;
        private IPasswordCodeService _passwordCodeService;
        
        public AccountController(IUserService userService, ICityService cityService, IPasswordCodeService passwordCodeService)
        {
            _userService = userService;
            _cityService = cityService;
            _passwordCodeService = passwordCodeService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Mail,string Password)
        {
            if (ModelState.IsValid)
            {
                var UserControl = _userService.GetAll()
                    .FirstOrDefault(u => u.Mail.Equals(Mail) && u.Password.Equals(Password));
                if (UserControl != null)
                {
                    HttpContext.Session.SetInt32("ıd", UserControl.Id);
                    HttpContext.Session.SetString("fullName", UserControl.Name + " " + UserControl.Surname);
                    return Redirect("~/Anasayfa/Anasayfa");
                }
            }

            return View();
            
        }
        

        [HttpGet]
        public ActionResult Register()
        {
            var model = new UserAddViewModel
            {
                User = new User(),
                City= _cityService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Register(User user)
        
        {
            if(ModelState.IsValid){
                if (_userService.GetUserByMail(user.Mail)==null)
                 {
                _userService.Add(user);
                return RedirectToAction("Login");
                    }
            }
            //return RedirectToAction("Register");
            return View(new UserAddViewModel{ 
                User = new User(),
                City= _cityService.GetAll()}
            );
        }

        public ActionResult LogOut()
        {
            HttpContext.Session.Clear();
            HttpContext.SignOutAsync();
            return Redirect("~/Anasayfa/Anasayfa");
        }

        public IActionResult SendCodeToUserMail(string Mail)
        {
            var user = _userService.GetUserByMail(Mail);
            if (user != null)
            {
                var Code = GeneratePasswordCode();
                _passwordCodeService.UserVeKodEkle(user,Code);
                string text = "<h1> Sıfırlama için kodunuz:</h1>+" + Code + " ";
                string subject = "Parola Sıfırlama";
                MailMessage message = new MailMessage("adwordsicin08@gmail.com",Mail,subject,text);
                message.IsBodyHtml = true;
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com",587);
                smtpClient.UseDefaultCredentials = false;
                NetworkCredential networkCredential = new NetworkCredential("adwordsicin08@gmail.com","fatikul123");
                smtpClient.Credentials = networkCredential;
                smtpClient.EnableSsl = true;
              //  smtpClient.UseDefaultCredentials = true;
                smtpClient.Send(message);
                return Redirect("ResetPasswordCode");
            }

            return View();

        }
        [HttpGet]
        public ActionResult ResetPasswordCode()
        {

            return View();
        }
        //[HttpPost]
        public ActionResult ResetPasswordCode(string code, string password)
        {
            
            var Code = _passwordCodeService.GetAll().FirstOrDefault(c => c.Code == code);
            if (Code == null)
            {
                return Redirect("Register");
            }
            var User = _userService.GetById(Code.UserID);
            User.Password = password;
            _userService.Update(User);
            
            return Redirect("Login");
        }
        //public ActionResult ResetPassword(string code, string Password)
        //{
        //    var Code = _passwordCodeService.GetAll().FirstOrDefault(c => c.Code == code);
        //    if (Code == null)
        //    {
        //        return Redirect("Login");
        //    }

        //    var model = new UserUpdateViewModel
        //    {
        //        User = _userService.GetById(Code.UserID)
                
        //    };
            
        //    return View(model);
        //}

        string? code= null;
        public string GeneratePasswordCode()
        {
          

            Random rnd = new Random();
            code = "";
            for (int i = 0; i < 6; i++)
            {
                char tmp = Convert.ToChar(rnd.Next(48, 58));
                code += tmp;
            }

            return code;
        }


        [HttpGet]
        public IActionResult UserDataUpdate()
        { 
            var UserId = HttpContext.Session.GetInt32("ıd");
           if(UserId!=null){
          
            var Id= Convert.ToInt32(UserId);
           
            var model = new UserUpdateViewModel
            {
                City =_cityService.GetAll(),
                User = _userService.GetById(Id)
            };
            return View(model);
            }

           return Redirect("Login");

        }
        [HttpPost]
        public IActionResult UserDataUpdate(User user)
        {
            _userService.Update(user);
            return Redirect("/Anasayfa/Anasayfa");
        }


    }

   
}
