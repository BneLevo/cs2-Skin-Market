using cs2_skins_market.Business.Interfaces;
using cs2_skins_market.Core.Models;
using cs2_skins_market.Data;
using cs2_skins_market.Data.Interfaces;
using cs2_skins_market.Data.Repositories;

namespace cs2_skins_market.Business.Services
{
    class SkinManager : ISkinService
    {
        private readonly ISkinRepository _skinRepo;

        public SkinManager()
        {
            _skinRepo = new MongoSkinRepository();
        }

        public List<Skin> GetAllSkins()
        {
            return _skinRepo.GetAllSkins();
        }

        public List<Skin> GetSkinsByFilter(string name, double min, double max)
        {
            return _skinRepo.GetSkinsByFilter(name, min, max);
        }
    }
}
