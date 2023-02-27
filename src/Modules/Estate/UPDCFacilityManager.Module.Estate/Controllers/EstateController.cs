using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Estates.ViewModels;
using UPDCFacilityManager.Modules.Estates.Services;

namespace UPDCFacilityManager.Module.Estates.Controllers
{
    public class EstateController : Controller
    {
        private readonly ILogger<EstateController> _logger;
        private readonly IMapper _mapper;
        private readonly IEstateService _estateService;

        public EstateController(
            ILogger<EstateController> logger,
            IEstateService estateService,
            IMapper mapper
            )
        {
            _logger = logger;
            _mapper = mapper;
            _estateService = estateService;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateUnit()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateEstateViewModel model, [FromQuery] string clusterId)
        {
            if (ModelState.IsValid)
            {
                var result = await _estateService.CreateAsync(model, clusterId);
                return RedirectToAction("Details", "Cluster", new { id = clusterId });
            }
            return View(model);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> EstateUnits( [FromRoute] string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                var result = await _estateService.GetUnitsAsync(id);
                return View(result);
            }
            return RedirectToAction("index", "Cluster");
        }
    }
}
