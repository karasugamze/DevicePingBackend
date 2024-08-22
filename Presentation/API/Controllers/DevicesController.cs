using Business.Abstract;
using Business.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private readonly IDeviceRepository _deviceRepository;  //depenceny injection
        public DevicesController(IDeviceRepository deviceRepository) 
        {
            _deviceRepository = deviceRepository;
        }

        [HttpGet]
        public IActionResult getAllDevice() {
            //DeviceRepository devicerep=new DeviceRepository(); 

            var model = _deviceRepository.GetAll();
            return Ok(model);
        }

    }
}
