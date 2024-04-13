using AutoMapper;
using Portal.Api.Data.Context;

namespace Portal.Api.DataServis
{
    public interface IOrganisationService : IBaseClientService
    {
    }
    public class OrganisationService : BaseClientService, IOrganisationService
    {
        public OrganisationService(ClientDataContext _cLientContext, GlobalDataContext _globalContext, IMapper _Imapper, ISessionService _sessionServis) : base(_cLientContext, _globalContext, _Imapper, _sessionServis)
        { 
        }
    }
}
