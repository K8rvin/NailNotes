using System;
using System.ComponentModel.DataAnnotations;

namespace LizokasNail.Core.Dao.Model
{
    public class User : EntityData
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
