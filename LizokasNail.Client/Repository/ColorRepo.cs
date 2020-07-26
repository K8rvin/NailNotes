using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Contract.Service;
using System.Collections.Generic;
using System.Linq;
using Unity;
using Unity.Resolution;

namespace LizokasNail.Client.Repository
{
    public class ColorRepo : IColorRepo
    {
        private readonly IUnityContainer _uc;
        private readonly IColorService _service;

        public ColorRepo(IUnityContainer uc, IColorService service)
        {
            _uc = uc;
            _service = service;
        }

        public ColorBl Get(int id)
        {
            var dto = _service.Get(id);
            return dto != null ? new ColorBl(dto) : null;
        }

        public virtual List<ColorBl> Get()
        {
            var dtos = _service.Get();
            return dtos?.Select(x => _uc.Resolve<ColorBl>(new ParameterOverride("dto", x))).ToList();
        }

        public ColorBl Add(ColorBl item)
        {
            var dto = _service.Add(item?.ToDto());
            return dto != null ? new ColorBl(dto) : null;
        }

        public ColorBl Update(ColorBl item)
        {
            var dto = _service.Update(item?.ToDto());
            return dto != null ? new ColorBl(dto) : null;
        }
    }
}
