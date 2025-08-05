using itec_lab1.Data;
using itec_lab1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Diagnostics;

namespace itec_lab1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ItecStockDbContext _context;
        private readonly IConfiguration _configuration;

        public HomeController(ItecStockDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Config()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOfficers()
        {
            var user = await _context.Officers
                .FromSqlRaw("SELECT * FROM officers")
                .ToListAsync();

            if (user != null)
                return Ok(user);
            else
                return NotFound("User not found");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
