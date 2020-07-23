using LizokasNail.Contract.Dto;
using System;
using System.ComponentModel.DataAnnotations;

namespace LizokasNail.Core.Dao.Model
{
    public class User : EntityData, IUserDto
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
