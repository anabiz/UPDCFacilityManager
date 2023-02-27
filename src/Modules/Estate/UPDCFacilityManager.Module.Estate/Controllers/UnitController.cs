using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Estates.Services;
using UPDCFacilityManager.Modules.Estates.ViewModels;

namespace UPDCFacilityManager.Module.Estates.Controllers
{
    public class UnitController : Controller
    {
        private readonly ILogger<EstateController> _logger;
        private readonly IMapper _mapper;
        private readonly IEstateService _estateService;
        public UnitController(
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
        public async Task<IActionResult> Index([FromRoute] string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                var result = await _estateService.GetUnitsAsync(id);
                TempData.Keep();
                return View(result);
            }
            return RedirectToAction("index", "Cluster");
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            TempData.Keep();
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateUnitViewModel model)
        {
            return View();
        }

    }
}
