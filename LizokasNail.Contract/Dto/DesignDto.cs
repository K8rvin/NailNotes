using System;

namespace LizokasNail.Contract.Dto
{
    public interface IDesignDto : IIdentity
    {
        string Name { get; set; }
        string Comment { get; set; }
    }

    public class DesignDto : Identity, IDesignDto
    {
        public DesignDto()
        {
        }

        public DesignDto(IDesignDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                Name = item.Name;
                Comment = item.Comment;
            }
        }

        public string Name { get; set; }
        public string Comment { get; set; }
    }
}
