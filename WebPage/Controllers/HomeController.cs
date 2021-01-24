using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Ada.Webpage.Models;
using Application.Queries;
using AutoMapper;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ada.Webpage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeQuery _homeQuery;
        private readonly IMapper _mapper;

        public HomeController(IHomeQuery homeQuery, IMapper mapper, ILogger<HomeController> logger)
        {
            _logger = logger;
            _mapper = mapper;
            _homeQuery = homeQuery;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _homeQuery.GetHomeModel();
            var vm = new HomeViewModel
            {
                Banner = _mapper.Map<List<BannerItem>>(result.Banner),
                Posts = _mapper.Map<List<PostSummary>>(result.Posts)
            };

            vm.Posts.ForEach(s => s.PostUri = new Uri(ControllerContext.HttpContext.Request.GetEncodedUrl()));

            return View(vm);
        }

        public IActionResult Privacy()
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
