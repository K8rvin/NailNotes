using LisokasNail.Models;
using System.Collections.Generic;

namespace LizokasNail.Client.Di
{
    public interface ITopRepo
    {
        TopBl Get(int id);
        List<TopBl> Get();
        TopBl Add(TopBl item);
        TopBl Update(TopBl item);
        void Delete(int id);
    }
}
