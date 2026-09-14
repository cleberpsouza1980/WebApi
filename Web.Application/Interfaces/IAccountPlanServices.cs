using Web.Application.DTOs;

namespace Web.Application.Interfaces
{
    public interface IAccountPlanServices
    {
        Task<IEnumerable<AccountPlanDto>> GetAllAccountPlansAsync();
        Task<AccountPlanDto> GetAllAccountByIdAsync(int id);
        Task<AccountPlanDto> DeleteAccountByIdAsync(int id);
        Task AddAsync(AccountPlanDto accountPlanDto);
    }
}
