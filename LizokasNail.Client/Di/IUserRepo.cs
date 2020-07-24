using LisokasNail.Models;
using System.Collections.Generic;

namespace LizokasNail.Client.Di
{
    public interface IUserRepo
    {
        UserBl Get(int id);
        List<UserBl> Get();
        UserBl Add(UserBl item);
        UserBl Update(UserBl item);
    }
}
