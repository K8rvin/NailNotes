﻿using LizokasNail.Contract.Dto;
using LizokasNail.Contract.Enum;
using System.Collections.Generic;

namespace LizokasNail.Core.Dao.Model
{
    public class User : EntityData, IUserDto
    {
        public User()
        {
            Records = new HashSet<Record>();
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public CommunicationType CommunicationType { get; set; }
        public string Comment { get; set; }
        public virtual ICollection<Record> Records { get; set; }
        public bool Vip { get; set; } = false;
    }
}
