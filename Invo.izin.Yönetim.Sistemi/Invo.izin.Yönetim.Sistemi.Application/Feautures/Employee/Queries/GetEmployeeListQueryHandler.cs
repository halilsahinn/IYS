#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Redis;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Parameter;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.BranchOffice;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Department;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using MediatR;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Text;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.Employee.Queries
{
    #region QUERY
    public class GetEmployeeListRequest : IRequest<List<EmployeeDto>>
    {
    }
    #endregion

    #region HANDLER
    public class GetEmployeeListQueryHandler : BaseHandler, IRequestHandler<GetEmployeeListRequest, List<EmployeeDto>>
    {
        #region FILEDS
        private readonly IEmployeeService _employeeRepository;
        #endregion

        #region CTOR
        public GetEmployeeListQueryHandler(IEmployeeService employeeRepository, IMapper mapper, IRedisService redisService) : base(mapper, redisService)
        {
            _employeeRepository = employeeRepository;
        }
        #endregion

        #region METHODS
        public  async Task<List<EmployeeDto>> Handle(GetEmployeeListRequest request, CancellationToken cancellationToken)
        {

           

            var cacheData = _redisService.GetData<List<EmployeeDto>>("employee");

            if (cacheData != null)
            {
                return cacheData;
            }

            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
           
            var employeeList = await _employeeRepository.GetEmployeeWithParameters();


            cacheData = _mapper.Map<List<EmployeeDto>>(employeeList);

            _redisService.SetData<List<EmployeeDto>>("employee", cacheData, expirationTime);

            return cacheData;



        }

 
        #endregion
    }

    #endregion
}
