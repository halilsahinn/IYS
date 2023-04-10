#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Parameter;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.BranchOffice;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Department;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using MediatR;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.BrancOffice.Queries
{
    #region QUERY
    public class GetBranchOfficeListRequest : IRequest<List<BranchOfficeDto>>
    {
    }
    #endregion

    #region HANDLER
    public class GetBranchOfficeListQueryHandler : BaseHandler, IRequestHandler<GetBranchOfficeListRequest, List<BranchOfficeDto>>
    {
        #region FILEDS
        private readonly IBranchOfficeService _branchOfficeListRepository;
        #endregion

        #region CTOR
        public GetBranchOfficeListQueryHandler(IBranchOfficeService branchOfficeListRepository, IMapper mapper) : base(mapper)
        {
            _branchOfficeListRepository = branchOfficeListRepository;
        }
        #endregion

        #region METHODS
        public async Task<List<BranchOfficeDto>> Handle(GetBranchOfficeListRequest request, CancellationToken cancellationToken)
        {

            var branchOfficeList = await _branchOfficeListRepository.GetAll();

            return _mapper.Map<List<BranchOfficeDto>>(branchOfficeList);
        }

        #endregion
    }

    #endregion

}
