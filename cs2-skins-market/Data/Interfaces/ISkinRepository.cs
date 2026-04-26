using cs2_skins_market.Core.Models;

namespace cs2_skins_market.Data.Interfaces
{
    interface ISkinRepository
    {
        List<Skin> GetAllSkins();
        void InsertMany(List<Skin> initialData);
    }
}
