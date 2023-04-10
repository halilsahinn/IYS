#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.BranchOffice;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using MediatR;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.BrancOffice.Queries
{

    #region QUERY
    public class GetBranchOfficeSelectListRequest : IRequest<List<SelectBranchOfficetDto>>
    {
    }
    #endregion

    #region HANDLER
    public class GetEmployeeTitileListQueryHandler : BaseHandler, IRequestHandler<GetBranchOfficeSelectListRequest, List<SelectBranchOfficetDto>>
    {
        #region FILEDS
        private readonly IDpBranchOfficeService _branchOfficeRepository;
        #endregion

        #region CTOR
        public GetEmployeeTitileListQueryHandler(IDpBranchOfficeService branchOfficeRepository, IMapper mapper) : base(mapper)
        {
            _branchOfficeRepository = branchOfficeRepository;
        }
        #endregion

        #region METHODS
        public async Task<List<SelectBranchOfficetDto>> Handle(GetBranchOfficeSelectListRequest request, CancellationToken cancellationToken)
        {

            var branchOfficeList = await _branchOfficeRepository.GetBranchOfficeSelectList();


            return branchOfficeList;


        }


        #endregion
    }

    #endregion
}
