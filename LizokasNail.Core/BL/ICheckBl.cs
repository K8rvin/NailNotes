using LizokasNail.Contract.Dto;
using System;
using System.Collections.Generic;

namespace LizokasNail.Core.BL
{
    public interface ICheckBl
    {
        IEnumerable<CheckDto> Get();
        IEnumerable<CheckDto> GetByPeriod(DateTime dateStart, DateTime dateEnd);
        CheckDto GetById(int id);
        CheckDto Add(CheckDto dto);
        CheckDto Update(CheckDto dto);
        void Delete(int id);
    }
}
