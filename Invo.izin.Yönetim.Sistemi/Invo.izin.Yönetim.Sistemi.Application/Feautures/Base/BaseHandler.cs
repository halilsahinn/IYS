#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.MemoryCache;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Redis;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.UnitOfWork;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.Base
{
    public abstract class BaseHandler
    {
        #region FIELDS
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public readonly IMemoryCacheService _memoryCache;
        public readonly IRedisService _redisService;
       
        #endregion

        #region CTOR
        protected BaseHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        protected BaseHandler(IUnitOfWork unitOfWork, IMapper mapper, IRedisService redisService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _redisService = redisService;
        }

        protected BaseHandler(IMapper mapper, IRedisService redisService)
        {
            
            _mapper = mapper;
            _redisService = redisService;
        }

        protected BaseHandler(IUnitOfWork unitOfWork, IMapper mapper, IMemoryCacheService memoryCache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _memoryCache = memoryCache;
        }
         protected BaseHandler(IMapper mapper)
        {

            _mapper = mapper;
        }
        #endregion

    }
}
