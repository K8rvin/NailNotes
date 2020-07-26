using LizokasNail.Contract.Dto;
using LizokasNail.Core.BL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LizokasNail.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopController : ControllerBase
    {
        private readonly ITopBl _bl;

        public TopController(ITopBl bl)
        {
            _bl = bl;
        }

        [HttpGet]
        public IEnumerable<TopDto> Get() => _bl.Get();

        [HttpGet("GetById", Name = "GetTopById")]
        public TopDto GetById([FromQuery] int Id)
        {
            return _bl.GetById(Id);
        }

        [HttpPost()]
        public ActionResult<TopDto> Add([FromBody] TopDto dto)
        {
            try
            {
                var item = _bl.Add(dto);
                return CreatedAtRoute("GetTopById", new { Id = item.Id }, item);
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        [HttpPut()]
        public ActionResult<TopDto> Update([FromBody] TopDto dto)
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
