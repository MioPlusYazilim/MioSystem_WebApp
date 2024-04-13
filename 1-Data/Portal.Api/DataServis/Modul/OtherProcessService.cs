using AutoMapper;
using Portal.Api.Data.Context;

namespace Portal.Api.DataServis
{
    public interface IOtherProcessService : IBaseClientService
    {
    }
    public class OtherProcessService : BaseClientService, IOtherProcessService
    {
        public OtherProcessService(ClientDataContext _cLientContext, GlobalDataContext _globalContext, IMapper _Imapper, ISessionService _sessionServis) : base(_cLientContext, _globalContext, _Imapper, _sessionServis)
        {
        }
    }
}
