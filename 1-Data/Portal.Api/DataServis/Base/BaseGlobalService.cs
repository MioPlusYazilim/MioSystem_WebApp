using AutoMapper;
using Portal.Api.Data.Context;
using Portal.Model;
using System;

namespace Portal.Api.DataServis.Base
{
    public interface IBaseGlobalService : IDisposable
    {
    }
    public class BaseGlobalService : IBaseGlobalService
    {
        public readonly SessionInformation session;
        public readonly IMapper imapper;
        public readonly GlobalDataContext dbContext;
        public readonly ISessionService sessionService;

        public BaseGlobalService(GlobalDataContext _context, IMapper _Imapper, ISessionService _sessionServis)
        {
            sessionService = _sessionServis;
            imapper = _Imapper;
            dbContext = _context;
            session = sessionService.sessionInfo;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
