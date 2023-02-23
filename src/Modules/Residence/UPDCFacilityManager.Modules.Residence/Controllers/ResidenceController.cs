using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Diagnostics;
using UPDCFacilityManager.Modules.Auth.Core.Services;
using UPDCFacilityManager.Modules.Cluster.Core.Services;
using UPDCFacilityManager.Modules.Residence.Core.ViewModels;
using UPDCFacilityManager.Shared.Models;

namespace UPDCFacilityManager.Modules.Residence.Controllers
{
    public class ResidenceController : Controller
    {
        private readonly ILogger<ResidenceController> _logger;
        private readonly IResidentService _residentService;
        private readonly IClusterService _clusterService;
        private readonly IMapper _mapper;
        public ResidenceController(
            ILogger<ResidenceController> logger,
            IResidentService residentService,
             IClusterService clusterService,
            IMapper mapper
            )
        {
            _logger = logger;
            _residentService = residentService;
            _clusterService = clusterService;
           _mapper = mapper;
        }

        public IActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public async  Task<IActionResult> Create()
        {
            var clusters = await _clusterService.BrowseAsync();
            List<SelectListItem> listItems = clusters.Select(x => new SelectListItem
            {
                Value = x.Id,
                Text = x.Name,
            }).ToList();

            listItems.Insert(0, new SelectListItem
            {
                Value = "",
                Text = ""
            });
            //ViewBag.ClusterList = listItems;
            TempData["ClusterList"] = JsonConvert.SerializeObject(listItems);
            TempData.Keep();
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateResidentViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _residentService.CreateAsync(model);
                return View("index");
            }
            TempData.Keep();
            return View(model);
        }
        public IActionResult Details()
        {
            return View();
        }

        public async Task<IActionResult> ListAllAsync()
        {
            var residents = await _residentService.BrowseAsync();
            return View(residents);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}