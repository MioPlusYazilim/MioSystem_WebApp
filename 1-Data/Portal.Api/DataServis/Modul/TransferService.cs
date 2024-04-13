using AutoMapper;
using Portal.Api.Data.Context;

namespace Portal.Api.DataServis
{
    public interface ITransferService : IBaseClientService
    {
    }
    public class TransferService : BaseClientService, ITransferService
    {
        public TransferService(ClientDataContext _cLientContext, GlobalDataContext _globalContext, IMapper _Imapper, ISessionService _sessionServis) : base(_cLientContext, _globalContext, _Imapper, _sessionServis)
        {
        }
    }
}
