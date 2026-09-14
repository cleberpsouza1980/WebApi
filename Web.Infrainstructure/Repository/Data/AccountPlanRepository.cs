using Microsoft.EntityFrameworkCore;
using Web.Dommain.Entities;
using Web.Dommain.Interfaces;
using Web.Infrainstructure.Data;

namespace Web.Infrainstructure.Repository.Data
{
    public class AccountPlanRepository : IAccountPlanRepositoy
    {
        private readonly AppDbContext _db;

        public AccountPlanRepository(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<AccountPlan>> GetAllAsync()
        {
            var r = await _db.AccountPlans.ToListAsync();
            return r;
        }
        public Task<AccountPlan> GetByIdAsync(int id)
        {
            var r = _db.AccountPlans.Where(p => p.Id == id).FirstOrDefaultAsync();
            return r;
        }
        public Task AddAsync(AccountPlan account)
        {
            return null;
        }
    }
}

