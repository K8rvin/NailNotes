using LizokasNail.Contract.Dto;
using LizokasNail.Core.BL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LizokasNail.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly IBaseBl _bl;

        public BaseController(IBaseBl bl)
        {
            _bl = bl;
        }

        [HttpGet]
        public IEnumerable<BaseDto> Get() => _bl.Get();

        [HttpGet("GetById", Name = "GetBaseById")]
        public BaseDto GetById([FromQuery] int Id)
        {
            return _bl.GetById(Id);
        }

        [HttpPost()]
        public ActionResult<BaseDto> Add([FromBody] BaseDto dto)
        {
            try
            {
                var item = _bl.Add(dto);
                return CreatedAtRoute("GetBaseById", new { Id = item.Id }, item);
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        [HttpPut()]
        public ActionResult<BaseDto> Update([FromBody] BaseDto dto)
        {
            try
            {
                return _bl.Update(dto);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
    }
}
