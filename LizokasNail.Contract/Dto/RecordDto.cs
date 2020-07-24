﻿using System;

namespace LizokasNail.Contract.Dto
{
    public interface IRecordDto : IIdentity
    {
        int UserId { get; set; }
        DateTime RecordDate { get; set; }
    }

    public class RecordDto : Identity, IRecordDto
    {
        public RecordDto()
        {
        }

        public RecordDto(IRecordDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                UserId = item.UserId;
                RecordDate = item.RecordDate;
            }
        }

        public int UserId { get; set; }
        public DateTime RecordDate { get; set; }
    }
}