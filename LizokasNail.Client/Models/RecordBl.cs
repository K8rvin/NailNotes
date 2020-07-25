using LizokasNail.Contract.Dto;
using System;

namespace LisokasNail.Models
{
    /// <summary>
    /// Запись на прием
    /// </summary>
    public class RecordBl : Identity
    {
        public RecordBl()
        {
        }

        public RecordBl(RecordDto dto)
        {
            if (dto != null)
            {
                Id = dto.Id;
                UserId = dto.UserId;
                RecordDate = dto.RecordDate;
                User = new UserBl(dto.User);
            }
        }

        public int UserId { get; set; }
        public DateTime RecordDate { get; set; }
        public UserBl User { get; set; }
        public string UserName => User?.Name;

        public RecordDto ToDto() => new RecordDto()
        {
            Id = Id,
            UserId = UserId,
            RecordDate = RecordDate,
        };
    }
}
