using cs2_skins_market.Core.Models;

namespace cs2_skins_market.Business.Interfaces
{
    public interface IPurchaseService
    {
        bool TryPurchaseCart(out string errorMessage);
        List<InventoryItem> GetInventory();
    }
}
