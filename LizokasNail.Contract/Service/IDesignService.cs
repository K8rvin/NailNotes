using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Contract.Service
{
    public interface IDesignService
    {
        DesignDto Get(int id);
        IEnumerable<DesignDto> Get();
        DesignDto Add(DesignDto item);
        DesignDto Update(DesignDto item);
        void Delete(int id);
    }
}
