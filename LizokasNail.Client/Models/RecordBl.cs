using LizokasNail.Contract.Dto;
using System;

namespace LisokasNail.Models
{
    /// <summary>
    /// Запись на прием
    /// </summary>
    public class RecordBl : Identity, IRecordDto
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
                Check = new CheckBl(dto.Check);
            }
        }

        public int UserId { get; set; }
        public DateTime RecordDate { get; set; }
        public UserBl User { get; set; }
        public CheckBl Check { get; set; }
        public string UserName => User?.Name;
        public string DisplayName => $"{RecordDate} ({UserName})";

        public RecordDto ToDto() => new RecordDto()
        {
            Id = Id,
            UserId = UserId,
            RecordDate = RecordDate,
            User = User.ToDto()
        };
    }
}
