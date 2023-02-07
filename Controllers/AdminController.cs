using Microsoft.AspNetCore.Mvc;
using SearchNavigator.Data.Interfaces.Services;
using SearchNavigator.Models;
using SearchNavigator.Services;

namespace SearchNavigator.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILeaseService _leaseService;

        public AdminController(ILeaseService leaseService)
        {
            _leaseService = leaseService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new AdminIndexModel
            {
                leases = _leaseService.GetActualLeases()
            });
        }
    }
}
