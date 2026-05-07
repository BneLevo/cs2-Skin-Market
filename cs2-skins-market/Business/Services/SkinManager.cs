/**************************************************************************
* Nom du fichier : SkinManager.cs
* Auteur : Ozgun Levent
* Date de création : 30.04.2026
* Description : Fournit des opérations de lecture/filtrage des skins.
**************************************************************************/

using cs2_skins_market.Business.Interfaces;
using cs2_skins_market.Core.Models;
using cs2_skins_market.Data;
using cs2_skins_market.Data.Interfaces;
using cs2_skins_market.Data.Repositories;

namespace cs2_skins_market.Business.Services
{
    /// <summary>
    /// Service d'accès aux skins (marketplace).
    /// </summary>
    public class SkinManager : ISkinService
    {
        private readonly ISkinRepository _skinRepo;

        /// <summary>
        /// Initialise le service de skins.
        /// </summary>
        public SkinManager()
        {
            _skinRepo = new MongoSkinRepository();
        }

        /// <summary>
        /// Retourne tous les skins disponibles.
        /// </summary>
        public List<Skin> GetAllSkins()
        {
            return _skinRepo.GetAllSkins();
        }

        /// <summary>
        /// Retourne les skins filtrés par nom et plage de prix.
        /// </summary>
        public List<Skin> GetSkinsByFilter(string name, double min, double max)
        {
            return _skinRepo.GetSkinsByFilter(name, min, max);
        }
    }
}
