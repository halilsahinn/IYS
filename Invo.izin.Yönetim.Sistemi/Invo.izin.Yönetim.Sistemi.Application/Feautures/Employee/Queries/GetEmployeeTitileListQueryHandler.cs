#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Department;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using MediatR;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.Employee.Queries
{

    #region QUERY
    public class GetEmployeeTitleRequestListRequest : IRequest<List<SelectEmployeeTitleDto>>
    {
    }
    #endregion

    #region HANDLER
    public class GetEmployeeTitileListQueryHandler : BaseHandler, IRequestHandler<GetEmployeeTitleRequestListRequest, List<SelectEmployeeTitleDto>>
    {
        #region FILEDS
        private readonly IDpEmployeeTitleService _employeeTitleRepository;
        #endregion

        #region CTOR
        public GetEmployeeTitileListQueryHandler(IDpEmployeeTitleService employeeTitleRepository, IMapper mapper) : base(mapper)
        {
            _employeeTitleRepository = employeeTitleRepository;
        }
        #endregion

        #region METHODS
        public async Task<List<SelectEmployeeTitleDto>> Handle(GetEmployeeTitleRequestListRequest request, CancellationToken cancellationToken)
        {

            var employeeTitleList = await _employeeTitleRepository.GetEmployeeTitleSelectList();


            return employeeTitleList;


        }


        #endregion
    }

    #endregion


}
