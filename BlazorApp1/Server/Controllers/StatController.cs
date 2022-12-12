using BlazorApp1.Server.ServerServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatController : ControllerBase
    {
        private readonly IStatService _statService;
        public StatController(IStatService statService)
        {
            _statService = statService;
        }

        [HttpGet]
        public async Task<ActionResult<int>> GetVisits()
        {
            return await _statService.GetVisits();
        }

        [HttpPost]
        public async Task  IncrementVisits()
        {
            await _statService.IncrementVisits();
        }
    }
}
