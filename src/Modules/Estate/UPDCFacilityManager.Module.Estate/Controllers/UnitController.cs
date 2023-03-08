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
using UPDCFacilityManager.Modules.Auth.Core.Entities;
using UPDCFacilityManager.Modules.Estates.ViewModels;

namespace UPDCFacilityManager.Module.Estates.Controllers
{
    public class UnitController : Controller
    {
        private readonly ILogger<EstateController> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitService _unitService;
        public UnitController(
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
                var result = await _unitService.GetUnitsAsync(id, search);
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
        public async Task<IActionResult> Create(CreateUnitViewModel model, [FromQuery] string estateId)
        {
            if (ModelState.IsValid)
            {
                await _unitService.CreateAsync(model, estateId);
                return RedirectToAction("Index", "Unit", new { id = estateId });
            }
            return View(model);
        }
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            var result = await _unitService.GetUnitByIdAsync(id);
            return View(result);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> DeleteUnit([FromRoute] string id)
        {
            await _unitService.DeleteUnitAsync(id);
            return RedirectToAction("index", "Unit");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit([FromQuery] string unitId)
        {
            var result = await _unitService.GetUnitToEditAsync(unitId);
            return View(result);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(EditUnitViewModel model, [FromQuery] string unitId)
        {
            var estateId = await _unitService.UpdateUnitAsync(model,unitId);
            return RedirectToAction("Index", "Unit", new { id = estateId }); ;
        }

    }
}
