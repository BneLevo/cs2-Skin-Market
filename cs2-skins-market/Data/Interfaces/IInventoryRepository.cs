using cs2_skins_market.Core.Models;

namespace cs2_skins_market.Data.Interfaces
{
    public interface IInventoryRepository
    {
        void InsertMany(List<InventoryItem> items);
        List<InventoryItem> GetByUsername(string username);
    }
}
