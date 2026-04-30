using cs2_skins_market.Core.Models;

namespace cs2_skins_market.Business.Interfaces
{
    interface ISkinService
    {
        List<Skin> GetAllSkins();
        List<Skin> GetSkinsByName(string name);
        List<Skin> GetSkinsByMinPrice(double min);
        List<Skin> GetSkinsByMaxPrice(double max);
        List<Skin> GetSkinsByPriceRange(double min, double max);
    }
}
