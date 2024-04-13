using AutoMapper;
using Portal.Api.Data.Context;

namespace Portal.Api.DataServis
{
    public interface IRentACarService : IBaseClientService
    {
    }
    public class RentACarService : BaseClientService, IRentACarService
    {
        public RentACarService(ClientDataContext _cLientContext, GlobalDataContext _globalContext, IMapper _Imapper, ISessionService _sessionServis) : base(_cLientContext, _globalContext, _Imapper, _sessionServis)
        {
        }
    }
}
