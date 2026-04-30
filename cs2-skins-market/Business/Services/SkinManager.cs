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

        public List<Skin> GetSkinsByName(string name)
        {
            return _skinRepo.GetSkinsByName(name);
        }

        public List<Skin> GetSkinsByMinPrice(double min)
        {
            return _skinRepo.GetSkinsByMinPrice(min);
        }

        public List<Skin> GetSkinsByMaxPrice(double max)
        {
            return _skinRepo.GetSkinsByMaxPrice(max);
        }
        public List<Skin> GetSkinsByPriceRange(double min, double max)
        {
            return _skinRepo.GetSkinsByPriceRange(min, max);
        }
    }
}
