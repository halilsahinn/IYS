#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.User;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.User;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using MediatR;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.User.Queries
{

    #region QUERY
    public class GetUserListQuery : IRequest<List<SelectUserDto>>
    {
    }
    #endregion

    #region HANDLER
    public class GetUserListQueryHandler : BaseHandler, IRequestHandler<GetUserListQuery, List<SelectUserDto>>
    {
        #region FILEDS
        private readonly IDpUserService _userRepository;
        #endregion

        #region CTOR
        public GetUserListQueryHandler(IDpUserService userRepository, IMapper mapper) : base(mapper)
        {
            _userRepository = userRepository;
        }
        #endregion

        #region METHODS
        public async Task<List<SelectUserDto>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {

            var userList = await _userRepository.GetUserSelectList();


            return _mapper.Map<List<SelectUserDto>>(userList);


        }


        #endregion
    }

    #endregion

}
