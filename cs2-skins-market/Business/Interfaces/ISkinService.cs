using cs2_skins_market.Core.Models;

namespace cs2_skins_market.Business.Interfaces
{
    interface ISkinService
    {
        List<Skin> GetAllSkins();
        //List<Skin> GetByCountry(string category);
    }
}
