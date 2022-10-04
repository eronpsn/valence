using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Valence.WebApp.Models.Login;

namespace Valence.WebApp.Controllers
{
    public class AcessoController : Controller
    {
        private readonly ILogger<AcessoController> _logger;

        public AcessoController(ILogger<AcessoController> logger)
        {
            _logger = logger;
        }
        public IActionResult Login(string ReturnUrl = "/Home/Index")
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToRoute("AbreHome");
            }
            LoginModel objLoginModel = new LoginModel();
            objLoginModel.ReturnUrl = ReturnUrl;
            return View(objLoginModel);
        }

        [Route("/Acesso/Login", Name = "AbreLogin")]
        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (login.Email == "eronpsn@gmail.com" && login.Password == "1")
                    {
                        _logger.LogInformation("Email " + login.Email + " Senha: " + login.Password);
                        Autenticar(login);
                        _logger.LogInformation("URL: " + login.ReturnUrl);
                        return LocalRedirect(login.ReturnUrl);
                    }
                    else
                    {
                        ViewBag.Message = "Usuário e/ou senha incorretos!";
                    }
                }
            }
            catch (Exception)
            {
                ViewBag.Message = "Ocorreu algum erro ao tentar se logar, tente novamente!";
            }
            return View(login);
        }
        private async void Autenticar(LoginModel login)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, login.Email),
                new Claim(ClaimTypes.Role, "Usuario_Comum")
            };

            var identidadeDeUsuario = new ClaimsIdentity(claims, "Login");
            ClaimsPrincipal claimPrincipal = new ClaimsPrincipal(identidadeDeUsuario);

            var propriedadesDeAutenticacao = new AuthenticationProperties
            {
                AllowRefresh = true,
                ExpiresUtc = DateTime.Now.ToLocalTime().AddHours(2),
                IsPersistent = true
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal, propriedadesDeAutenticacao);
        }
        public async Task<IActionResult> Sair()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToRoute("AbreLogin");
        }

    }
}