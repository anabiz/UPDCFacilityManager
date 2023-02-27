using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UPDCFacilityManager.Modules.Auth.Core.Data;
using UPDCFacilityManager.Modules.Cluster.Core.Services;
using UPDCFacilityManager.Modules.Cluster.Core.ViewModels;

namespace UPDCFacilityManager.Modules.Cluster.Controllers
{
    public class ClusterController : Controller
    {
        private readonly ILogger<ClusterController> _logger;
        private readonly IClusterService _clusterService;
        private readonly IMapper _mapper;
        private readonly AppDbContext _appDbContext;

        public ClusterController(
            ILogger<ClusterController> logger,
            IClusterService clusterService,
            IMapper mapper,
            AppDbContext appDbContext
            ) 
        {
            _logger = logger;
            _clusterService = clusterService;
            _mapper = mapper;
            _appDbContext = appDbContext;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var clusters = await _clusterService.BrowseAsync();
            return View(clusters);
        }

        [Authorize,HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateClusterViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _clusterService.CreateAsync(model);
                return RedirectToAction("index");
            }
            return View(model);
        }

        [Authorize, HttpGet]
        public async Task<IActionResult> Details([FromRoute] string id)
        {
            var result = await _clusterService.GetEstatesByClusterId(id);
            return View(result);
        }

        #region Estate
        // GET: //5
        [HttpGet]
        public async Task<JsonResult> GetEstateByClusterId(string clusterId)
        {
            var result = await _appDbContext.Estates.Where(x => x.ClusterId == clusterId)
                .Select(x => new SelectListItem
                {
                    Value = x.Id,
                    Text = x.Name
                }).ToListAsync();

            if (!string.IsNullOrWhiteSpace(clusterId))
            {
                return Json(result);
            }

            return null;
        }

        [HttpGet]
        public async Task<JsonResult> GetUnitByEstateId(string estateId)
        {
            var result = await _appDbContext.Units.Where(x => x.EstateId == estateId)
                    .Select(x => new SelectListItem
                    {
                        Value = x.Id,
                        Text = x.Name
                    }).ToListAsync();

            if (!string.IsNullOrWhiteSpace(estateId))
            {
                return Json(result);
            }
            return null;
        }

        [HttpGet]
        public async Task<IActionResult> EstateDetails(string id)
        {
            return View("~/Views/Estate/EstateDetails.cshtml");
        }
        #endregion
    }
}
