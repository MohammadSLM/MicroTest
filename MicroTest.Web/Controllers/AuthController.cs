using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MicroTest.Web.Models;
using MicroTest.Web.Service.IService;
using MicroTest.Web.Utility;

namespace MicroTest.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoginRequestDto loginRequestDto = new();
            return View(loginRequestDto);
        }

        [HttpGet]
        public IActionResult Register()
        {
            var roleList = new List<SelectListItem>()
            {
                new SelectListItem{Text = SD.RoleAdmin, Value = SD.RoleAdmin},
                new SelectListItem{Text = SD.RoleCustomer, Value = SD.RoleCustomer}
            };

            ViewBag.RoleList = roleList;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequestDto model)
        {
            ResponseDto result = await _authService.RegisterAsync(model);
            ResponseDto assingRole;

            if (result!=null && result.IsSuccess)
            {
                if (string.IsNullOrEmpty(model.Role))
                {
                    model.Role = SD.RoleCustomer;
                }
                assingRole = await _authService.AssignRoleAsync(model);
                if (assingRole!=null && assingRole.IsSuccess)
                {
                    TempData["success"] = "Registration Successful";
                    return RedirectToAction(nameof(Login));
                }

            }

            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}
