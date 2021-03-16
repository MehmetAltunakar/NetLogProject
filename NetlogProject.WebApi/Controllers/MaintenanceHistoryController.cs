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
    public class MaintenanceHistoryController : ControllerBase
    {
      
            private readonly IMaintenanceHistoryBusiness _maintenanceHistoryBusiness;
            public MaintenanceHistoryController(IMaintenanceHistoryBusiness maintenanceHistoryBusiness)
            {
                _maintenanceHistoryBusiness = maintenanceHistoryBusiness;
            }

            [HttpGet]
            public IActionResult Get(int id)
            {
                var response = new ResponseViewModel();
                response = _maintenanceHistoryBusiness.Get(id);

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
                    response = _maintenanceHistoryBusiness.List();

                    if (!response.IsSuccess)
                    {
                        if (response.Data == null)
                            return NotFound(response);

                        return BadRequest(response);
                    }
                    return Ok(response);
                }

            [HttpPost]
                public IActionResult Add(MaintenanceHistoryRequest maintenanceHistoryRequest)
                {
                    var response = new ResponseViewModel();
                    response = _maintenanceHistoryBusiness.Add(maintenanceHistoryRequest);

                    if (!response.IsSuccess)
                    {
                        return BadRequest(response);
                    }

                    return Ok(response);
                }

            [HttpPut]
            public IActionResult Edit(MaintenanceHistoryRequest maintenanceHistoryRequest)
            {
                var response = new ResponseViewModel();
                response = _maintenanceHistoryBusiness.Update(maintenanceHistoryRequest);

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
                response = _maintenanceHistoryBusiness.Delete(id);

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

