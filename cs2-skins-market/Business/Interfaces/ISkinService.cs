/**************************************************************************
* Nom du fichier : ISkinService.cs
* Auteur : Ozgun Levent
* Date de création : 30.04.2026
* Description : Contrat pour accéder et filtrer les skins.
**************************************************************************/

using cs2_skins_market.Core.Models;

namespace cs2_skins_market.Business.Interfaces
{
    /// <summary>
    /// Définit les opérations de lecture et de filtrage des skins.
    /// </summary>
    public interface ISkinService
    {
        /// <summary>
        /// Retourne tous les skins.
        /// </summary>
        List<Skin> GetAllSkins();

        /// <summary>
        /// Retourne les skins correspondant aux critères de filtre.
        /// </summary>
        List<Skin> GetSkinsByFilter(string name, double min, double max);
    }
}

