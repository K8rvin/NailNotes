using System;

namespace LizokasNail.Contract.Dto
{
    public interface IBaseDto : IIdentity
    {
        string Name { get; set; }
    }

    public class BaseDto : Identity, IBaseDto
    {
        public BaseDto()
        {
        }

        public BaseDto(IBaseDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                Name = item.Name;
            }
        }

        public string Name { get; set; }
    }
}
