using Web.Dommain.Entities;
using Web.Dommain.Interfaces;

namespace Web.Dommain.Services
{
    public class AccountServicesDommain : IAccountServicesDommain
    {
        private readonly IAccountPlanRepositoy _repositoyAccount;
        public AccountServicesDommain(IAccountPlanRepositoy repositoyAccount)         
        {
            _repositoyAccount = repositoyAccount;
        }
        public Exception Validation(AccountPlan accountPlanDTO)
        {

            if (accountPlanDTO == null)
                throw new ArgumentNullException(nameof(accountPlanDTO), "AccountPlanDTO cannot be null.");

            if (accountPlanDTO.Id == 0)
                throw new ArgumentNullException("ID not null");

            return null;

        }
    }
}
