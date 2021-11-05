using ASP.NetCV.AppCode.Extensions;
using ASP.NetCV.FormModels;
using ASP.NetCV.Models.DataContext;
using ASP.NetCV.Models.Entities.Membership;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASP.NetCV.Controllers
{
    public class AccountController : Controller
    {
        readonly UserManager<User> userManager;
         readonly SignInManager<User> signInManager;
        readonly IConfiguration configuration;
        readonly CvDbContext vv;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration, CvDbContext vv)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.configuration = configuration;
            this.vv = vv;
        }
        [AllowAnonymous]
        public IActionResult SignIn()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "Home");

            }
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task< IActionResult> SignIn(LoginFormModel model)
        {

            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "Home");

            }
            if (ModelState.IsValid) //her shey qaydasndadrsa
            {
                User user = null;
               
                if (model.UserName.IsEmail())
                {
                    user = await userManager.FindByEmailAsync(model.UserName); //Eger Isdifadeci email gore giris edibse onu yoxlayir
                }
                else
                {
                    user = await userManager.FindByNameAsync(model.UserName);//eger isdifadeci username le daxil olubsa onu yoxlayir
                }

                if (user == null) //isdifadeci olmuyanda view gonder
                {
                    ViewBag.Ms = "Isdifadeci sifreniz ve ya parolnuz yanlisdir";
                    return View(user);
                }
                if (user.EmailConfirmed == false)
                {
                    ViewBag.Ms = " Emailinizi testiq et!!";
                    return View(user);
                }
                //if( await userManager.IsInRoleAsync(user, "user")) //databazada yolxuyur bele user var yoxsa yox
                //{
                //    ViewBag.Ms = "Isdifadeci adiniz ve ya parolnuz yanlisdir";   ///admin sign in de yazmaliyam
                //    return View(user);
                //}
                if (user.Active == false)
                {
                    ViewBag.Ms = "Sizin girisinize qada var";
                    return View(user);
                }
                if (user.Active == true)
                {
                    var result = await signInManager.PasswordSignInAsync(user, model.Password, true, true);//giris edildi
                    if (result.Succeeded != true) // girisniz ugursuz oldu
                    {
                        ViewBag.Ms = "Isdifadeci sifresi ve parol sehvdir";
                        return View(user);

                    }
                    var redirectUrl = Request.Query["ReturnUrl"];

                    if (!string.IsNullOrWhiteSpace(redirectUrl))
                    {
                        return Redirect(redirectUrl);
                    }

                    return RedirectToAction("Index", "About");
                }


            }
            ViewBag.Ms = "Melumatlari doldurun";
            return View(model);
        }
        [AllowAnonymous]




        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult>  Register(RegisterFormModel model)
        {
            if (ModelState.IsValid)//her shey qaydasindadirsa
            {
                var user = new User();
                user.Email = model.Email;
                user.EmailConfirmed = true;
                user.UserName = model.UserName;
                user.Name = model.Name;
                user.Surname = model.SurName;


                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    string path = $"{Request.Scheme}://{Request.Host}/registration-confirmm?email={user.Email}&token={token}"; // path duzeldirik
                    var emailRespons = configuration.SendEmail(user.Email, "Portfolio user registration", $"Zehmet olmasa <a href={path}>Link</a> vasitesile abuneliyi tamamlayin");//sorgu gonderirik emaile
                    if (emailRespons)
                    {
                        ViewBag.Ms = "Siz qeydiyyatdan ugurla kecidiniz";
                    }
                    else
                    {
                        ViewBag.Ms = "E-maile gondererken sehf askar olundu yeniden cehd edin";
                    }

                    
                    return RedirectToAction(nameof(SignIn));
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
            }


            return View();
        }

        public async Task<IActionResult> RegisterConfirm(string email,string token)
        {
            var faundUser = await userManager.FindByEmailAsync(email);//email axtarir
            if (faundUser == null)
            {
                ViewBag.Ms = "Xetali token";
                goto end;
            }
            var result = await userManager.ConfirmEmailAsync(faundUser, token);///eger tapibsa qeydiyyat tesdiqle

            if (!result.Succeeded)
            {
                ViewBag.Ms = "Xetali token";
                goto end;
            }
            ViewBag.Ms = "Hesabiniz ugurla tesdiqlendi";
        end:// her shey qaydasindadrsa
            return RedirectToAction(nameof(SignIn));
        }

        //[HttpGet]
        //[Route("subscribe-confirmm")]
        //public IActionResult SubscibeConfirm(string token)   //token gelecey
        //{
        //    token = token.Decrypte("");

        //    Match match = Regex.Match(token, @"subscribetoken-(?<id>[a-zA-Z0-9]*)(.*)-(?<timeStampt>\d{14})");
        //    if (match.Success)
        //    {
        //        string id = match.Groups["id"].Value;
        //        string executeTimeStamp = match.Groups["executeTimeStamp"].Value;
        //        var subsc = vv.Users.FirstOrDefault(s => s.UserName == id);
        //        if (subsc == null)
        //        {
        //            ViewBag.ms = Tuple.Create(true, "Token xetasi");
        //            goto end;
        //        }
        //        if (subsc.EmailConfirmed == true)
        //        {
        //            ViewBag.ms = Tuple.Create(true, "Artiq tesdiq edildi");
        //            goto end;
        //        }
        //        subsc.EmailConfirmed = true;
        //        vv.SaveChanges();
        //        ViewBag.ms = Tuple.Create(false, "Abuneliyiniz tesdiq edildi");
        //    }
        //end:
        //    return View();
        //}







    }
}
