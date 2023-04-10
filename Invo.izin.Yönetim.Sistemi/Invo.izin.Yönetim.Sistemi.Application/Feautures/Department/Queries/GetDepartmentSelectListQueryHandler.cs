#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Department;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.User;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using MediatR;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.Department.Queries
{
    #region QUERY
    public class GetDepartmentSelectListRequest : IRequest<List<SelectDepartmentDto>>
    {
    }
    #endregion

    #region HANDLER
    public class GetDepartmentSelectListQueryHandler : BaseHandler, IRequestHandler<GetDepartmentSelectListRequest, List<SelectDepartmentDto>>
    {
        #region FILEDS
        private readonly IDpDepartmentService _departmentRepository;
        #endregion

        #region CTOR
        public GetDepartmentSelectListQueryHandler(IDpDepartmentService departmentRepository, IMapper mapper) : base(mapper)
        {
            _departmentRepository = departmentRepository;
        }
        #endregion

        #region METHODS
        public async Task<List<SelectDepartmentDto>> Handle(GetDepartmentSelectListRequest request, CancellationToken cancellationToken)
        {

            var departmentList = await _departmentRepository.GetDepartmentSelectList();


            return departmentList;


        }


        #endregion
    }

    #endregion
}
