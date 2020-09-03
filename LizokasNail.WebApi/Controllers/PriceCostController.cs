using LizokasNail.Contract.Dto;
using LizokasNail.Core.BL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LizokasNail.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceCostController : ControllerBase
    {
        private readonly IPriceCostBl _bl;

        public PriceCostController(IPriceCostBl bl)
        {
            _bl = bl;
        }

        [HttpGet]
        public IEnumerable<PriceCostDto> Get() => _bl.Get();

        [HttpGet("GetById", Name = "GetPriceCostById")]
        public PriceCostDto GetById([FromQuery] int Id)
        {
            return _bl.GetById(Id);
        }

        [HttpPost()]
        public ActionResult<PriceCostDto> Add([FromBody] PriceCostDto dto)
        {
            try
            {
                var item = _bl.Add(dto);
                return CreatedAtRoute("GetPriceCostById", new { Id = item.Id }, item);
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        [HttpPut()]
        public ActionResult<PriceCostDto> Update([FromBody] PriceCostDto dto)
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
