using LisokasNail.Models;
using System.Collections.Generic;

namespace LizokasNail.Client.Di
{
    public interface IBaseRepo
    {
        BaseBl Get(int id);
        List<BaseBl> Get();
        BaseBl Add(BaseBl item);
        BaseBl Update(BaseBl item);
    }
}
