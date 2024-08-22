using Business.Abstract.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IPingServices _pingServices;

        public ServiceController(IPingServices pingServices)
        {
            _pingServices = pingServices;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var model = await _pingServices.getPingList();
            return Ok(model);
        }
    }
}
