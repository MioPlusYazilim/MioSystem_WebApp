using AutoMapper;
using Portal.Api.Data.Context;
using Portal.Model;
using System;

namespace Portal.Api.DataServis
{
    public interface IBaseClientService : IDisposable
    {
    }
    public class BaseClientService : IBaseClientService
    {
        public readonly SessionInformation session;
        public readonly IMapper imapper;
        public readonly ClientDataContext clientContext;
        public readonly GlobalDataContext globalContext;
        public readonly ISessionService sessionService;

        public BaseClientService(ClientDataContext _clientContext,GlobalDataContext _globalContext, IMapper _Imapper, ISessionService _sessionServis)
        {
            sessionService = _sessionServis;
            imapper = _Imapper;
            clientContext = _clientContext;
            globalContext = _globalContext;
            session = sessionService.sessionInfo;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
