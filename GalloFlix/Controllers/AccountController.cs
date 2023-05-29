using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GalloFlix.DataTransferObjects;
using GalloFlix.Models;
using Microsoft.AspNetCore.Identity;
using System.Net.Mail;
using System.Security.Claims;

namespace GalloFlix.Controllers;

    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly SignInManager<AppUser> _singInManager;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(
        ILogger<AccountController> logger,
        SignInManager<AppUser> signInManager,
        UserManager<AppUser> userManager)
        {
            _logger = logger;
            _singInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            LoginDto loginDto = new();
            loginDto.ReturnUrl = returnUrl ?? Url.Content("~/");
            return View(loginDto);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginDto login)

        {
            // Se o model é válido, faz login
            if (ModelState.IsValid)
            {
                string userName = login.Email;
                if (IsValidEmail(login.Email))
                {
                    var user = await _userManager.FindByEmailAsync(login.Email);
                    if (user != null)
                        userName = user.UserName;
                }

                var result = await  _singInManager.PasswordSignInAsync(
                    userName,login.Password, login.RememberMe, lockoutOnFailure: true
                );
                if (result.Succeeded)
                {
                    _logger.LogInformation($"Usuário { login.Email } acessou o sitema");
                    return LocalRedirect(login.ReturnUrl);
                }
                if (result.IsLockedOut)
                {
                    _logger.LogInformation($"Usuário { login.Email } está bloqueado");
                    return RedirectToAction("Lockout");
                }
                ModelState.AddModelError("login", "Usuário e/ou Senha Inválidos!!!");
            }
            return View(login);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            _logger.LogInformation($"Usuário {ClaimTypes.Email} fez logoff");
            await _singInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [AllowAnonymous]

        public IActionResult Register()
        {
            return View();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress m = new(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        } 

    }
