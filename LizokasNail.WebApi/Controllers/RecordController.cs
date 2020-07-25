using LizokasNail.Contract.Dto;
using LizokasNail.Core.BL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LizokasNail.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private readonly IRecordBl _bl;

        public RecordController(IRecordBl bl)
        {
            _bl = bl;
        }

        [HttpGet]
        public IEnumerable<RecordDto> Get() => _bl.Get();

        [HttpGet("GetById", Name = "GetRecordById")]
        public RecordDto GetById([FromQuery] int Id)
        {
            return _bl.GetById(Id);
        }

        [HttpPost()]
        public ActionResult<RecordDto> Add([FromBody] RecordDto dto)
        {
            try
            {
                var item = _bl.Add(dto);
                return CreatedAtRoute("GetRecordById", new { Id = item.Id }, item);
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        [HttpPut()]
        public ActionResult<RecordDto> Update([FromBody] RecordDto dto)
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
