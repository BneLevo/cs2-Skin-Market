namespace cs2_skins_market.Business.Interfaces
{
    public interface IAuthService
    {
        bool TryRegister(string username, string password, double budget, out string errorMessage);
        bool TryLogin(string username, string password, out string errorMessage);
        double GetBudget();
        bool TryDepositFunds(double amount, out string errorMessage);
    }
}
