using LizokasNail.Contract.Dto;
using LizokasNail.Core.BL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LizokasNail.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckController : ControllerBase
    {
        private readonly ICheckBl _bl;

        public CheckController(ICheckBl bl)
        {
            _bl = bl;
        }

        [HttpGet]
        public IEnumerable<CheckDto> Get() => _bl.Get();

        [HttpGet("GetById", Name = "GetCheckById")]
        public CheckDto GetById([FromQuery] int Id)
        {
            return _bl.GetById(Id);
        }

        [HttpPost()]
        public ActionResult<CheckDto> Add([FromBody] CheckDto dto)
        {
            try
            {
                var item = _bl.Add(dto);
                return CreatedAtRoute("GetCheckById", new { Id = item.Id }, item);
            }
            catch (Exception ex)
            {
                return Conflict($"{ex.Message}: {ex?.InnerException}");
            }
        }

        [HttpPut()]
        public ActionResult<CheckDto> Update([FromBody] CheckDto dto)
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
