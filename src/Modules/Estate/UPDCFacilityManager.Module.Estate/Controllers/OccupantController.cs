using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Module.Estates.Services;
using UPDCFacilityManager.Module.Estates.ViewModels;

namespace UPDCFacilityManager.Module.Estates.Controllers
{
    public class OccupantController : Controller
    {
        private readonly ILogger<EstateController> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitService _unitService;
        public OccupantController(
            ILogger<EstateController> logger,
            IMapper mapper,
            IUnitService unitService
            )
        {
            _logger = logger;
            _mapper = mapper;
            _unitService = unitService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index([FromRoute] string id, [FromQuery] string search)
        {
            if (!string.IsNullOrEmpty(id))
            {
                var result = await _unitService.GetUnitOccupantsAsync(id, search);
                TempData.Keep();
                return View( result);
            }
            return RedirectToAction("index", "Cluster");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> DeleteOccupant([FromRoute] string id)
        {
            await _unitService.DeleteOccupantAsync(id);
            return RedirectToAction("index", "Unit");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            var result = await _unitService.GetOccupantByIdAsync(id);
            return View("Delete", result);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create([FromQuery] string unitId)
        {
            TempData["unitId"] = unitId;
            return View("Create");
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateOccupantViewModel model, [FromQuery] string unitId)
        {
            if (ModelState.IsValid)
            {
                await _unitService.CreateOccupantAsync(model, unitId);
                return RedirectToAction("Index", new { id = unitId });
            }
            return View(model);
        }
    }
}
