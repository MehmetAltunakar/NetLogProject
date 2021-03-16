using Microsoft.AspNetCore.Authorization;
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
    public class UserController : ControllerBase
    {
        private readonly IUserBusiness _userService;
        public UserController(IUserBusiness userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var response = new ResponseViewModel();
            response = _userService.Get(id);

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
            response = _userService.List();

            if (!response.IsSuccess)
            {
                if (response.Data == null)
                    return NotFound(response);

                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Add(UserRequest userRequest)
        {
            var response = new ResponseViewModel();
            response = _userService.Add(userRequest);

            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPut]
        public IActionResult Edit(UserRequest userRequest)
        {
            var response = new ResponseViewModel();
            response = _userService.Update(userRequest);

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
            response = _userService.Delete(id);

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
