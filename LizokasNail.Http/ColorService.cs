using Flurl;
using Flurl.Http;
using LizokasNail.Contract.Dto;
using LizokasNail.Contract.Service;
using System.Collections.Generic;

namespace LizokasNail.Http
{
    public class ColorService : ServiceBase, IColorService
    {
        public ColorDto Get(int Id)
        {
            return Url.AppendPathSegment("Color/GetById")
                .SetQueryParam("Id", Id)
                .GetJsonAsync<ColorDto>().Result;
        }

        public IEnumerable<ColorDto> Get()
        {
            return Url.AppendPathSegment("Color")
                .GetJsonAsync<IEnumerable<ColorDto>>().Result;
        }

        public ColorDto Add(ColorDto item)
        {
            return Url.AppendPathSegment("Color")
                    .PostJsonAsync(item).ReceiveJson<ColorDto>().Result;
        }

        public ColorDto Update(ColorDto item)
        {
            return Url.AppendPathSegment("Color")
                .PutJsonAsync(item).ReceiveJson<ColorDto>().Result;
        }

        public void Delete(int Id)
        {
            Url.AppendPathSegment("Color")
                .SetQueryParam("Id", Id).DeleteAsync();
        }
    }
}
