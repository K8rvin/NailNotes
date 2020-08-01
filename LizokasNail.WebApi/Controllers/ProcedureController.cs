using LizokasNail.Contract.Dto;
using LizokasNail.Core.BL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LizokasNail.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcedureController : ControllerBase
    {
        private readonly IProcedureBl _bl;

        public ProcedureController(IProcedureBl bl)
        {
            _bl = bl;
        }

        [HttpGet]
        public IEnumerable<ProcedureDto> Get() => _bl.Get();

        [HttpGet("GetById", Name = "GetProcedureById")]
        public ProcedureDto GetById([FromQuery] int Id)
        {
            return _bl.GetById(Id);
        }

        [HttpPost()]
        public ActionResult<ProcedureDto> Add([FromBody] ProcedureDto dto)
        {
            try
            {
                var item = _bl.Add(dto);
                return CreatedAtRoute("GetProcedureById", new { Id = item.Id }, item);
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        [HttpPut()]
        public ActionResult<ProcedureDto> Update([FromBody] ProcedureDto dto)
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
