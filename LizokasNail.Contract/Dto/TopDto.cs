using System;

namespace LizokasNail.Contract.Dto
{
    public interface ITopDto : IIdentity
    {
        string Name { get; set; }
        string Comment { get; set; }
    }

    public class TopDto : Identity, ITopDto
    {
        public TopDto()
        {
        }

        public TopDto(ITopDto item)
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
