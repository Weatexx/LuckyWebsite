using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using holiganbet.Models;
using holiganbet.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using holiganbet.Models.AdminViewModels;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace holiganbet.Controllers.Admin;

[Authorize]
public class AdminController : Controller
{
    private readonly HoliganDbContext db = new HoliganDbContext(); // dependency injection nesnesi
    public AdminController(HoliganDbContext _db) // Dep'i parametre olarak ekledik.
    {
        db = _db; // dependency injection yaptık. 
    }

    public IActionResult Index()
    {
        return View();
    }

    [AllowAnonymous]
    public IActionResult Login()
    {
        return View();
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Login(AdminsVM postedData)
    {
        if (!ModelState.IsValid)
        {
            return View(postedData);
        }

        var admin = (from x in db.Admins
                     where x.Username == postedData.Username && x.Password == postedData.Password
                     select x
                    ).FirstOrDefault();


        if (admin != null)
        {
            var claims = new List<Claim>{
                new Claim(ClaimTypes.Name, admin.Username),
                new Claim("admin",admin.Id.ToString()),
                new Claim("role","admin")
            };

            var claimsIdendity = new ClaimsIdentity(claims, "Cookies", "user", "role");
            var claimsPrinciple = new ClaimsPrincipal(claimsIdendity);

            await HttpContext.SignInAsync(claimsPrinciple);

            return Redirect("/Admin/Index");
        }

        else
        {
            TempData["NotFound"] = "Yanlış kullanıcı adı veya parola.";
        }

        return View();
    }

    [Route("/Admin/Logout")]
    public async Task<IActionResult> Signout()
    {
        await HttpContext.SignOutAsync();
        return Redirect("/Admin");
    }

    [Route("/Admin/Users")]
    public IActionResult Users()
    {
        List<UsersVM> UserList = (from x in db.Users
                                  select new UsersVM
                                  {
                                      Id = x.Id,
                                      Email = x.Email,
                                      Username = x.Username,
                                      Password = x.Password,
                                      Name = x.Name,
                                      Surname = x.Surname,
                                  }).ToList();

        db.Dispose();
        return View(UserList);
    }

    [Route("/Admin/Offers")]
    public IActionResult Offers()
    {
        List<OffersVM> OffersList = (from x in db.Offers
                                     select new OffersVM
                                     {
                                         Id = x.Id,
                                         Username = x.Username,
                                         MoneyAmount = x.Moneyamount,
                                         OfferDateTime = x.Datetime.ToString()
                                     }).ToList();

        db.Dispose();
        return View(OffersList);
    }

    [Route("/Admin/Admins")]
    public IActionResult Admins()
    {
        List<AdminsVM> AdminList = (from x in db.Admins
                                    select new AdminsVM
                                    {
                                        Id = x.Id,
                                        Username = x.Username,
                                        Password = x.Password
                                    }).ToList();

        db.Dispose();
        return View(AdminList);
    }

    [Route("/Admin/Logins")]
    public IActionResult Logins()
    {
        List<LoginsVM> LoginList = (from x in db.Logins
                                    select new LoginsVM
                                    {
                                        Id = x.Id,
                                        Username = x.Username,
                                        Password = x.Password
                                    }).ToList();

        db.Dispose();
        return View(LoginList);
    }

    public async Task<IActionResult> UserDelete(int id)
    {
        User silinecekKullanici = db.Users.Find(id);
        if (silinecekKullanici != null)
        {
            db.Users.Remove(silinecekKullanici);
            await db.SaveChangesAsync();
        }

        return Redirect("/Admin/Users");
    }

    public async Task<IActionResult> OfferDelete(int id)
    {
        Offer silinecekTalep = db.Offers.Find(id);
        if (silinecekTalep != null)
        {
            db.Offers.Remove(silinecekTalep);
            await db.SaveChangesAsync();
        }

        return Redirect("/Admin/Offers");
    }

    public async Task<IActionResult> LoginDelete(int id)
    {
        Login silinecekTalep = db.Logins.Find(id);
        if (silinecekTalep != null)
        {
            db.Logins.Remove(silinecekTalep);
            await db.SaveChangesAsync();
        }

        return Redirect("/Admin/Logins");
    }

}