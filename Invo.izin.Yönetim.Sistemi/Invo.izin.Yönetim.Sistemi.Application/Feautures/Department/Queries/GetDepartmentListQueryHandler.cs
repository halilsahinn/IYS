#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Parameter;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Department;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using MediatR;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.Department.Queries
{
    #region QUERY
    public class GetDepartmentListRequest : IRequest<List<DepartmentDto>>
    {
    }
    #endregion

    #region HANDLER
    public class GetDepartmentListQueryHandler : BaseHandler, IRequestHandler<GetDepartmentListRequest, List<DepartmentDto>>
    {
        #region FILEDS
        private readonly IDepartmentService _departmentRepository;
        #endregion

        #region CTOR
        public GetDepartmentListQueryHandler(IDepartmentService departmentRepository, IMapper mapper) : base(mapper)
        {
            _departmentRepository = departmentRepository;
        }
        #endregion

        #region METHODS
        public async Task<List<DepartmentDto>> Handle(GetDepartmentListRequest request, CancellationToken cancellationToken)
        {

            var departmentList = await _departmentRepository.GetAll();

            return _mapper.Map<List<DepartmentDto>>(departmentList);
        }

        #endregion
    }

    #endregion

}
