using LizokasNail.Contract.Dto;
using Microsoft.AspNetCore.Mvc;
using LizokasNail.Core.BL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LizokasNail.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBl _bl;

        public UserController(IUserBl bl)
        {
            _bl = bl;
        }

        // GET: api/User
        [HttpGet]
        public IEnumerable<UserDto> Get() => _bl.Get();

        [HttpGet("GetById")]
        public UserDto GetById([FromQuery] int Id)
        {
            return _bl.GetById(Id);
        }
    }
}
