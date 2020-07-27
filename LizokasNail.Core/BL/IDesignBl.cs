using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Core.BL
{
    public interface IDesignBl
    {
        IEnumerable<DesignDto> Get();

        DesignDto GetById(int id);
        DesignDto Add(DesignDto dto);
        DesignDto Update(DesignDto dto);
        void Delete(int id);
    }
}
