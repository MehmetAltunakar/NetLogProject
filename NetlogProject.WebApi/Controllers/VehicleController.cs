using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetlogProject.Business.Abstract;
using NetlogProject.Entity.Request;
using NetlogProject.Entity.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetlogProject.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleBusiness _vehicleBusiness;
        public VehicleController(IVehicleBusiness vehicleBusiness)
        {
            _vehicleBusiness = vehicleBusiness;
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var response = new ResponseViewModel();
            response = _vehicleBusiness.Get(id);

            if (!response.IsSuccess)
            {
                if (response.Data == null)
                    return NotFound(response);

                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpGet("List")]
        public IActionResult List()
        {
            var response = new ResponseViewModel();
            response = _vehicleBusiness.List();

            if (!response.IsSuccess)
            {
                if (response.Data == null)
                    return NotFound(response);

                return BadRequest(response);
            }
            return Ok(response);
        }


        [HttpPost]
        public IActionResult Add(VehicleRequest vehicleRequest)
        {
            var response = new ResponseViewModel();
            response = _vehicleBusiness.Add(vehicleRequest);

            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPut]
        public IActionResult Edit(VehicleRequest vehicleRequest)
        {
            var response = new ResponseViewModel();
            response = _vehicleBusiness.Update(vehicleRequest);

            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var response = new ResponseViewModel();
            response = _vehicleBusiness.Delete(id);

            if (!response.IsSuccess)
            {
                if (response.Data == null)
                {
                    return NotFound(response);
                }
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
