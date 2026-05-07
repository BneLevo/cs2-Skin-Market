/**************************************************************************
* Nom du fichier : PurchaseService.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Gère les achats du panier et l'inventaire utilisateur.
**************************************************************************/

using cs2_skins_market.Business.Interfaces;
using cs2_skins_market.Core;
using cs2_skins_market.Core.Models;
using cs2_skins_market.Data.Interfaces;
using cs2_skins_market.Data.Repositories;

namespace cs2_skins_market.Business.Services
{
    /// <summary>
    /// Service de gestion des achats et de l'inventaire.
    /// </summary>
    public class PurchaseService : IPurchaseService
    {
        private readonly IUserRepository _userRepository;
        private readonly IInventoryRepository _inventoryRepository;

        /// <summary>
        /// Initialise le service d'achat.
        /// </summary>
        public PurchaseService()
        {
            _userRepository = new MongoUserRepository();
            _inventoryRepository = new MongoInventoryRepository();
        }

        /// <summary>
        /// Tente d'acheter tous les éléments présents dans le panier.
        /// </summary>
        public bool TryPurchaseCart(out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(AppSession.Username))
            {
                errorMessage = "You are not logged in.";
                return false;
            }

            if (AppSession.Cart.Count == 0)
            {
                errorMessage = "Your cart is empty.";
                return false;
            }

            var user = _userRepository.GetByUsername(AppSession.Username);
            if (user == null)
            {
                errorMessage = "User not found.";
                return false;
            }

            var total = AppSession.Cart.Sum(s => s.Price);
            if (total > user.Budget)
            {
                errorMessage = $"Insufficient budget. Cart total: ${total:N2}, your budget: ${user.Budget:N2}.";
                return false;
            }

            var purchasedAt = DateTime.UtcNow;
            var purchasedItems = AppSession.Cart.Select(s => new InventoryItem
            {
                Username = user.Username,
                SkinId = s.Id,
                Name = s.Name,
                Price = s.Price,
                PurchasedAt = purchasedAt
            }).ToList();

            _userRepository.UpdateBudget(user.Username, user.Budget - total);
            _inventoryRepository.InsertMany(purchasedItems);
            AppSession.Cart.Clear();
            return true;
        }

        /// <summary>
        /// Retourne l'inventaire de l'utilisateur connecté.
        /// </summary>
        public List<InventoryItem> GetInventory()
        {
            if (string.IsNullOrWhiteSpace(AppSession.Username))
            {
                return new List<InventoryItem>();
            }

            return _inventoryRepository.GetByUsername(AppSession.Username);
        }
    }
}
