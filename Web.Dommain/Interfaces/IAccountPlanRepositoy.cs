using Web.Dommain.Entities;

namespace Web.Dommain.Interfaces
{
    public interface IAccountPlanRepositoy
    {
        Task AddAsync(AccountPlan account);
        Task<IEnumerable<AccountPlan>> GetAllAsync();
        Task<AccountPlan> GetByIdAsync(int id);
    }
}
