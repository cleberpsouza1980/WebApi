using Web.Dommain.Entities;

namespace Web.Dommain.Interfaces
{
    public interface IAccountServicesDommain
    {
        Exception Validation(AccountPlan accountPlan);
    }
}
