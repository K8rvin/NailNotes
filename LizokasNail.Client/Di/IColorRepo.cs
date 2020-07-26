using LisokasNail.Models;
using System.Collections.Generic;

namespace LizokasNail.Client.Di
{
    public interface IColorRepo
    {
        ColorBl Get(int id);
        List<ColorBl> Get();
        ColorBl Add(ColorBl item);
        ColorBl Update(ColorBl item);
        void Delete(int id);
    }
}
