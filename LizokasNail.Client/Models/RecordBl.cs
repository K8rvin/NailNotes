using LizokasNail.Contract.Dto;
using System;
using System.Collections.Generic;

namespace LisokasNail.Models
{
    /// <summary>
    /// Запись на прием
    /// </summary>
    public class RecordBl : Identity, IRecordDto
    {
        public RecordBl()
        {
            Record2Procedure = new HashSet<Record2ProcedureDto>();
        }

        public RecordBl(RecordDto dto)
        {
            if (dto != null)
            {
                Id = dto.Id;
                UserId = dto.UserId;
                RecordDate = dto.RecordDate;
                User = new UserBl(dto.User);
                Check = new CheckBl(dto.Check);
                Record2Procedure = dto.Record2Procedure;
            }
        }

        public int UserId { get; set; }
        public DateTime RecordDate { get; set; }
        public UserBl User { get; set; }
        public CheckBl Check { get; set; }
        public IEnumerable<Record2ProcedureDto> Record2Procedure { get; set; }

        public string UserName => User?.Name;
        public string DisplayName => $"{RecordDate} ({UserName}){((User?.Vip == true) ? " [VIP клиент]" : "")}";

        public RecordDto ToDto() => new RecordDto()
        {
            Id = Id,
            UserId = UserId,
            RecordDate = RecordDate,
            User = User?.ToDto(),
            Record2Procedure = Record2Procedure,
        };
    }
}
