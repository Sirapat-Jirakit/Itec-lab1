using Azure.Core;
using itec_lab1.Data;
using itec_lab1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace itec_lab1.Controllers
{
    public class UsersController : Controller
    {
        private readonly ItecStockDbContext _context;
        private readonly IConfiguration _configuration;

        public UsersController(ItecStockDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public IActionResult Login()
        {
            return View(new Users());
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var user = await _context.Users
                .FromSqlRaw("SELECT * FROM users WHERE Email = {0}", email)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                ViewBag.LoginError = "User not found.";
                return View("~/Views/Home/Index.cshtml");
            }

            var storedPassword = user.Password;
            if (storedPassword == password)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.LoginError = "Invalid password.";
                return View("~/Views/Home/Index.cshtml");
            }

        }

        [HttpPost]
        public async Task<IActionResult> Register(Users user)
        {
            if (await _context.Users.AnyAsync(u => u.Email == user.Email))
            {
                ViewBag.LoginError = "Email already exists.";
                return View("~/Views/Home/Index.cshtml");
            }

            user.CreatedAt = DateTime.UtcNow;
            user.UpdatedAt = DateTime.UtcNow;
            user.IsActive = true;

            string sql = @"
            INSERT INTO Users (Name, Email, Password, CreatedAt, UpdatedAt, IsActive)
            VALUES ({0}, {1}, {2}, {3}, {4}, {5})";

            await _context.Database.ExecuteSqlRawAsync(
                sql,
                user.Name,
                user.Email,
                user.Password,
                user.CreatedAt,
                user.UpdatedAt,
                user.IsActive
            );

            return RedirectToAction("Index", "Home");

        }
    }
}
