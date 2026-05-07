using cs2_skins_market.Core.Models;

namespace cs2_skins_market.Data.Interfaces
{
    public interface IUserRepository
    {
        AppUser GetByUsername(string username);
        bool UsernameExists(string username);
        void Insert(AppUser user);
        void UpdateBudget(string username, double newBudget);
        void IncrementBudget(string username, double delta);
    }
}
