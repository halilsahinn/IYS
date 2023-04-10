#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Parameter;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Department;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.EmployeeTitle;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using MediatR;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.EmployeeTitle.Queries
{

    #region QUERY
    public class GetEmployeeTitleRequestListRequest : IRequest<List<EmployeeTitleDto>>
    {
    }
    #endregion

    #region HANDLER
    public class GetDepartmentListQueryHandler : BaseHandler, IRequestHandler<GetEmployeeTitleRequestListRequest, List<EmployeeTitleDto>>
    {
        #region FILEDS
        private readonly IEmployeeTitleService _employeeTitleRepository;
        #endregion

        #region CTOR
        public GetDepartmentListQueryHandler(IEmployeeTitleService employeeTitleRepository, IMapper mapper) : base(mapper)
        {
            _employeeTitleRepository = employeeTitleRepository;
        }
        #endregion

        #region METHODS
        public async Task<List<EmployeeTitleDto>> Handle(GetEmployeeTitleRequestListRequest request, CancellationToken cancellationToken)
        {

            var employeeTitleList = await _employeeTitleRepository.GetAll();

            return _mapper.Map<List<EmployeeTitleDto>>(employeeTitleList);
        }

        #endregion
    }

    #endregion
}
