using LizokasNail.Contract.Dto;
using LizokasNail.Core.BL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LizokasNail.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignController : ControllerBase
    {
        private readonly IDesignBl _bl;

        public DesignController(IDesignBl bl)
        {
            _bl = bl;
        }

        [HttpGet]
        public IEnumerable<DesignDto> Get() => _bl.Get();

        [HttpGet("GetById", Name = "GetDesignById")]
        public DesignDto GetById([FromQuery] int Id)
        {
            return _bl.GetById(Id);
        }

        [HttpPost()]
        public ActionResult<DesignDto> Add([FromBody] DesignDto dto)
        {
            try
            {
                var item = _bl.Add(dto);
                return CreatedAtRoute("GetDesignById", new { Id = item.Id }, item);
            }
            catch (Exception ex)
            {
                return Conflict($"{ex.Message}: {ex?.InnerException}");
            }
        }

        [HttpPut()]
        public ActionResult<DesignDto> Update([FromBody] DesignDto dto)
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

        [HttpDelete()]
        public ActionResult Delete(int Id)
        {
            try
            {
                _bl.Delete(Id);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }

            return Ok();
        }
    }
}
