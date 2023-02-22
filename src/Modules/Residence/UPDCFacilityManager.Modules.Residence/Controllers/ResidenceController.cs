using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using UPDCFacilityManager.Modules.Auth.Core.Entities;
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
            var listItems = clusters.Select(x => new
            {
                Value = x.Id,
                Text = x.Name,
            }).ToList();

            listItems.Insert(0, new
            {
                Value = "",
                Text = ""
            });
            ViewBag.ClusterList = listItems;
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateResidentViewModel model)
        {
           
            await _residentService.CreateAsync(model);
            return View("index");
        }
        public IActionResult Details()
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