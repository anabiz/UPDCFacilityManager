using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using UPDCFacilityManager.Bootstrapper.Models;

namespace UPDCFacilityManager.Bootstrapper.Controllers
{
    public class ResidenceController : Controller
    {
        private readonly ILogger<ResidenceController> _logger;

        public ResidenceController(ILogger<ResidenceController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}