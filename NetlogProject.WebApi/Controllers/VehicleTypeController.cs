using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetlogProject.Business.Abstract;
using NetlogProject.Business.Concrete;
using NetlogProject.Entity.Request;
using NetlogProject.Entity.Response;
using NetlogProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetlogProject.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehicleTypeController : ControllerBase
    {
        private readonly IVehicleTypeBusiness _vehicleTypeBusiness;
        public VehicleTypeController(IVehicleTypeBusiness vehicleTypeBusiness)
        {
            _vehicleTypeBusiness = vehicleTypeBusiness;
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var response = new ResponseViewModel();
            response = _vehicleTypeBusiness.Get(id);

            if (!response.IsSuccess)
            {
                if (response.Data == null)
                    return NotFound(response);

                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Add(VehicleTypeRequest vehicleTypeRequest)
        {
            var response = new ResponseViewModel();
            response = _vehicleTypeBusiness.Add(vehicleTypeRequest);

            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPut]
        public IActionResult Edit(VehicleTypeRequest vehicleTypeRequest)
        {
            var response = new ResponseViewModel();
            response = _vehicleTypeBusiness.Update(vehicleTypeRequest);

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
            response = _vehicleTypeBusiness.Delete(id);

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
