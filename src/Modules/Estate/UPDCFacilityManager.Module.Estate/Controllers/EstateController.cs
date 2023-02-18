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

namespace UPDCFacilityManager.Module.Estate.Controllers
{
    public class EstateController : Controller
    {
        private readonly ILogger<EstateController> _logger;
        private readonly IMapper _mapper;

        public EstateController(
            ILogger<EstateController> logger,
            IMapper mapper
            )
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
