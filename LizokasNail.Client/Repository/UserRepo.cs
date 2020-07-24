using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Contract.Dto;
using LizokasNail.Contract.Service;
using System.Collections.Generic;
using System.Linq;
using Unity;
using Unity.Resolution;

namespace LizokasNail.Client.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly IUnityContainer _uc;
        private readonly IUserService _service;

        public UserRepo(IUnityContainer uc, IUserService service)
        {
            _uc = uc;
            _service = service;
        }

        public UserBl Get(int id)
        {
            UserDto dto = _service.Get(id);
            return dto != null ? new UserBl(dto) : null;
        }

        public virtual List<UserBl> Get()
        {
            var dtos = _service.Get();
            return dtos?.Select(x => _uc.Resolve<UserBl>(new ParameterOverride("dto", x))).ToList();
        }

        public UserBl Add(UserBl item)
        {
            var dto = _service.Add(item?.ToDto());
            return dto != null ? new UserBl(dto) : null;
        }

        public UserBl Update(UserBl item)
        {
            var dto = _service.Update(item?.ToDto());
            return dto != null ? new UserBl(dto) : null;
        }
    }
}
