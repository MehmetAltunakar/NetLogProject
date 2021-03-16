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
    public class PictureGroupController : ControllerBase
    {
        private readonly IPictureGroupBusiness _pictureGroupBusiness;
        public PictureGroupController(IPictureGroupBusiness pictureGroupBusiness)
        {
            _pictureGroupBusiness = pictureGroupBusiness;
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var response = new ResponseViewModel();
            response = _pictureGroupBusiness.Get(id);

            if (!response.IsSuccess)
            {
                if (response.Data == null)
                    return NotFound(response);

                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Add(PictureGroupRequest pictureGroupRequest)
        {
            var response = new ResponseViewModel();
            response = _pictureGroupBusiness.Add(pictureGroupRequest);

            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPut]
        public IActionResult Edit(PictureGroupRequest pictureGroupRequest)
        {
            var response = new ResponseViewModel();
            response = _pictureGroupBusiness.Update(pictureGroupRequest);

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
            response = _pictureGroupBusiness.Delete(id);

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
