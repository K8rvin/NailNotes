using LizokasNail.Contract.Dto;
using LizokasNail.Core.BL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LizokasNail.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private readonly IColorBl _bl;

        public ColorController(IColorBl bl)
        {
            _bl = bl;
        }

        [HttpGet]
        public IEnumerable<ColorDto> Get() => _bl.Get();

        [HttpGet("GetById", Name = "GetColorById")]
        public ColorDto GetById([FromQuery] int Id)
        {
            return _bl.GetById(Id);
        }

        [HttpPost()]
        public ActionResult<ColorDto> Add([FromBody] ColorDto dto)
        {
            try
            {
                var item = _bl.Add(dto);
                return CreatedAtRoute("GetColorById", new { Id = item.Id }, item);
            }
            catch (Exception ex)
            {
                return Conflict($"{ex.Message}: {ex?.InnerException}");
            }
        }

        [HttpPut()]
        public ActionResult<ColorDto> Update([FromBody] ColorDto dto)
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
