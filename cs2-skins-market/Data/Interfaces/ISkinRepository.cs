/**************************************************************************
* Nom du fichier : ISkinRepository.cs
* Auteur : Ozgun Levent
* Date de création : 30.04.2026
* Description : Contrat repository pour les skins.
**************************************************************************/

using cs2_skins_market.Core.Models;

namespace cs2_skins_market.Data.Interfaces
{
    /// <summary>
    /// Définit les opérations d'accès aux skins (marketplace).
    /// </summary>
    public interface ISkinRepository
    {
        /// <summary>
        /// Retourne tous les skins.
        /// </summary>
        List<Skin> GetAllSkins();

        /// <summary>
        /// Insère une liste de skins (seed).
        /// </summary>
        void InsertMany(List<Skin> initialData);

        /// <summary>
        /// Retourne les skins filtrés par nom et plage de prix.
        /// </summary>
        List<Skin> GetSkinsByFilter(string name, double min, double max);

        /// <summary>
        /// Retourne le nombre de documents de la collection.
        /// </summary>
        long GetCount();
    }
}

