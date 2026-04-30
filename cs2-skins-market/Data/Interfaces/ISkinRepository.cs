using cs2_skins_market.Core.Models;

namespace cs2_skins_market.Data.Interfaces
{
    interface ISkinRepository
    {
        List<Skin> GetAllSkins();
        void InsertMany(List<Skin> initialData);

        // Filter 
        List<Skin> GetSkinsByName(string name);
        List<Skin> GetSkinsByMinPrice(double min);
        List<Skin> GetSkinsByMaxPrice(double max);
        List<Skin> GetSkinsByPriceRange(double min, double max);

    }
}
