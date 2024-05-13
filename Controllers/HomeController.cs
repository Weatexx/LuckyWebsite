using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using holiganbet.Models;
using holiganbet.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using holiganbet.Models.AdminViewModels;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using holiganbet.Models.ViewModels;

namespace holiganbet.Controllers
{
    public class HomeController : Controller
    {
        private readonly HoliganDbContext _db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(HoliganDbContext db, ILogger<HomeController> logger)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/Kayit")]
        public IActionResult Kayit()
        {
            return View();
        }

        [Route("/CanliCasino")]
        public IActionResult CanliCasino()
        {
            return View();
        }

        [Route("/Casino")]
        public IActionResult Casino()
        {
            return View();
        }

        [Route("/OzelOran")]
        public IActionResult OzelOran()
        {
            return View();
        }

        [Route("/OdulluOyunlar")]
        public IActionResult OdulluOyunlar()
        {
            return View();
        }

        [Route("/Tombala")]
        public IActionResult Tombala()
        {
            return View();
        }

        [Route("/Turnuvalar")]
        public IActionResult Turnuvalar()
        {
            return View();
        }

        [Route("/OzelTurnuvalar")]
        public IActionResult OzelTurnuvalar()
        {
            return View();
        }

        [Route("/Contact")]
        public IActionResult Contact()
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
            return Redirect("Login/Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contact(ContactsVM gelenData)
        {
            if (!ModelState.IsValid)
            {
                return View(gelenData);
            }

            else
            {
                Contact yeniContact = new Contact
                {
                    Namesurname = gelenData.Namesurname,
                    Phone = gelenData.Phone
                };
                await _db.AddAsync(yeniContact);
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
