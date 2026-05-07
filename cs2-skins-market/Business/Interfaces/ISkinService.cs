using cs2_skins_market.Core.Models;

namespace cs2_skins_market.Business.Interfaces
{
    public interface ISkinService
    {
        List<Skin> GetAllSkins();
        List<Skin> GetSkinsByFilter(string name, double min, double max);
    }
}

