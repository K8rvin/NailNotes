using LisokasNail.Models;
using System.Collections.Generic;

namespace LizokasNail.Client.Di
{
    public interface IDesignRepo
    {
        DesignBl Get(int id);
        List<DesignBl> Get();
        DesignBl Add(DesignBl item);
        DesignBl Update(DesignBl item);
        void Delete(int id);
    }
}
