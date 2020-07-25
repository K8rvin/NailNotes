using Flurl;
using Flurl.Http;
using LizokasNail.Contract.Dto;
using LizokasNail.Contract.Service;
using System.Collections.Generic;

namespace LizokasNail.Http
{
    public class UserService : ServiceBase, IUserService
    {
        public UserDto Get(int Id)
        {
            return Url.AppendPathSegment("user/GetById")
                .SetQueryParam("Id", Id)
                .GetJsonAsync<UserDto>().Result;
        }

        public IEnumerable<UserDto> Get()
        {
            return Url.AppendPathSegment("user")
                .GetJsonAsync<IEnumerable<UserDto>>().Result;
        }

        public UserDto Add(UserDto item)
        {
            return Url.AppendPathSegment("user")
                .PostJsonAsync(item).ReceiveJson<UserDto>().Result;
        }

        public UserDto Update(UserDto item)
        {
            return Url.AppendPathSegment("user")
                .PutJsonAsync(item).ReceiveJson<UserDto>().Result;
        }
    }
}
