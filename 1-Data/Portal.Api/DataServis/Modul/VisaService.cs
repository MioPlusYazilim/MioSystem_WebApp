using AutoMapper;
using Portal.Api.Data.Context;

namespace Portal.Api.DataServis
{
    public interface IVisaService : IBaseClientService
    {
    }
    public class VisaService : BaseClientService, IVisaService
    {
        public VisaService(ClientDataContext _cLientContext, GlobalDataContext _globalContext, IMapper _Imapper, ISessionService _sessionServis) : base(_cLientContext, _globalContext, _Imapper, _sessionServis)
        {
        }
    }
}
