/**************************************************************************
* Nom du fichier : IInventoryRepository.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Contrat repository pour l'inventaire utilisateur.
**************************************************************************/

using cs2_skins_market.Core.Models;

namespace cs2_skins_market.Data.Interfaces
{
    /// <summary>
    /// Définit les opérations d'accès à l'inventaire.
    /// </summary>
    public interface IInventoryRepository
    {
        /// <summary>
        /// Insère plusieurs éléments d'inventaire.
        /// </summary>
        void InsertMany(List<InventoryItem> items);

        /// <summary>
        /// Retourne les éléments d'inventaire d'un utilisateur.
        /// </summary>
        List<InventoryItem> GetByUsername(string username);
    }
}
