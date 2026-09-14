using AutoMapper;
using System.ComponentModel;
using Web.Application.DTOs;
using Web.Application.Interfaces;
using Web.Dommain.Entities;
using Web.Dommain.Interfaces;

namespace Web.Application.AccontServices
{
    public class AccountPlanServices : IAccountPlanServices
    {
        private readonly IAccountPlanRepositoy _accountPlanRepository;
        private readonly IAccountServicesDommain _accountPlanServices;
        private readonly IMapper _mapper;
        public AccountPlanServices(IAccountPlanRepositoy accountPlanRepositoy, IAccountServicesDommain accountPlanServices,
            IMapper mapper)
        {
            _accountPlanRepository = accountPlanRepositoy;
            _accountPlanServices = accountPlanServices;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AccountPlanDto>> GetAllAccountPlansAsync()
        {
            var p = await _accountPlanRepository.GetAllAsync();

            var t = _mapper.Map<IEnumerable<AccountPlanDto>>(p);

            return t;
        }

        public async Task<AccountPlanDto> GetAllAccountByIdAsync(int id)
        {
            var p = await _accountPlanRepository.GetByIdAsync(id);

            var t = _mapper.Map<AccountPlanDto>(p);

            return t;
        }

        public async Task<AccountPlanDto> DeleteAccountByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task AddAsync(AccountPlanDto accountPlanDto)
        {
            var account = _mapper.Map<AccountPlanDto, AccountPlan>(accountPlanDto);

            var vl = _accountPlanServices.Validation(account);

            if (vl != null)
                throw new Exception(vl.Message);

            await _accountPlanRepository.AddAsync(account);

        }
    }
}
