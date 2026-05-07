/**************************************************************************
* Nom du fichier : IPurchaseService.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Contrat pour l'achat du panier et l'inventaire.
**************************************************************************/

using cs2_skins_market.Core.Models;

namespace cs2_skins_market.Business.Interfaces
{
    /// <summary>
    /// Définit les opérations d'achat et de consultation d'inventaire.
    /// </summary>
    public interface IPurchaseService
    {
        /// <summary>
        /// Tente d'acheter tous les éléments du panier.
        /// </summary>
        bool TryPurchaseCart(out string errorMessage);

        /// <summary>
        /// Retourne l'inventaire de l'utilisateur connecté.
        /// </summary>
        List<InventoryItem> GetInventory();
    }
}
