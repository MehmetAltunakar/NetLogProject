﻿using Microsoft.AspNetCore.Http;
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
    public class ActionTypeController : ControllerBase
    {
      
            private readonly IActionTypeBusiness _actionTypeBusiness;
            public ActionTypeController(IActionTypeBusiness actionTypeBusiness)
            {
            _actionTypeBusiness = actionTypeBusiness;
            }

            [HttpGet]
            public IActionResult Get(int id)
            {
                var response = new ResponseViewModel();
                response = _actionTypeBusiness.Get(id);

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
                response = _actionTypeBusiness.List();

                if (!response.IsSuccess)
                {
                    if (response.Data == null)
                        return NotFound(response);

                    return BadRequest(response);
                }
                return Ok(response);
            }

        [HttpPost]
            public IActionResult Add(ActionTypeRequest actionTypeRequest)
            {
                var response = new ResponseViewModel();
                response = _actionTypeBusiness.Add(actionTypeRequest);

                if (!response.IsSuccess)
                {
                    return BadRequest(response);
                }

                return Ok(response);
            }

            [HttpPut]
            public IActionResult Edit(ActionTypeRequest actionTypeRequest)
            {
                var response = new ResponseViewModel();
                response = _actionTypeBusiness.Update(actionTypeRequest);

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
                response = _actionTypeBusiness.Delete(id);

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
