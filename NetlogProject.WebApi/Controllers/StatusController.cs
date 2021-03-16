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
    public class StatusController : ControllerBase
    {
        private readonly IStatusBusiness _statusBusiness;
        public StatusController(IStatusBusiness statusBusiness)
        {
            _statusBusiness = statusBusiness;
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var response = new ResponseViewModel();
            response = _statusBusiness.Get(id);

            if (!response.IsSuccess)
            {
                if (response.Data == null)
                    return NotFound(response);

                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Add(StatusRequest statusRequest)
        {
            var response = new ResponseViewModel();
            response = _statusBusiness.Add(statusRequest);

            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPut]
        public IActionResult Edit(StatusRequest statusRequest)
        {
            var response = new ResponseViewModel();
            response = _statusBusiness.Update(statusRequest);

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
            response = _statusBusiness.Delete(id);

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
