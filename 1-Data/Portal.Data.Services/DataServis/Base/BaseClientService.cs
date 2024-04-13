using AutoMapper;
using Portal.Data.Context;
using Portal.Data.Entities.GlobalEntities;
using Portal.Helpers;
using Portal.Model;

namespace Portal.Data.Services
{
    public interface IBaseClientService : IDisposable
    {
    }
    public class BaseClientService : IBaseClientService
    {
        public  ClientDataContext clientContext;
        public  GlobalDataContext globalContext;
        public IMapper mapper;
        public readonly LoginResponse loginResponse;

        public BaseClientService(LoginResponse _loginResponse)
        {
            this.loginResponse = _loginResponse;
            SetDbContext();
            mapper = createMapConfig().CreateMapper();
        }
        public BaseClientService()
        {
            this.loginResponse = LoginResponse.GetLoginResponse();
            SetDbContext();
            mapper = createMapConfig().CreateMapper();
        }

        public virtual MapperConfiguration createMapConfig()
        {
            var config = new MapperConfiguration(cfg =>
            {
               

            });
            return config;
        }
        void SetDbContext()
        {
            string globalConnstr = string.Empty;
            string clientConnstr = string.Empty;
            using (CryptoManager engine = new CryptoManager(""))
            {
                globalConnstr = engine.Decrypt(this.loginResponse.globalKey);
                clientConnstr = engine.Decrypt(this.loginResponse.clientKey);
            }

            globalContext = new GlobalDataContext(globalConnstr);
            clientContext = new ClientDataContext(clientConnstr);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
