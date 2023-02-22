using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UPDCFacilityManager.Modules.Cluster.Core.Services;
using UPDCFacilityManager.Modules.Cluster.Core.ViewModels;

namespace UPDCFacilityManager.Modules.Cluster.Controllers
{
    public class ClusterController : Controller
    {
        private readonly ILogger<ClusterController> _logger;
        private readonly IClusterService _clusterService;
        private readonly IMapper _mapper;
        public ClusterController(
            ILogger<ClusterController> logger,
            IClusterService clusterService,
            IMapper mapper
            ) 
        {
            _logger = logger;
            _clusterService = clusterService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateClusterViewModel model)
        {

            await _clusterService.CreateAsync(model);
            return View("index");
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
