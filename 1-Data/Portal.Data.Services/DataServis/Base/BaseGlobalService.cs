using AutoMapper;
using Portal.Data.Context;
using Portal.Helpers;
using Portal.Model;

namespace Portal.Data.Services.Base
{
    public interface IBaseGlobalService : IDisposable
    {
    }
    public class BaseGlobalService : IBaseGlobalService
    {
        public GlobalDataContext dbContext;
        public readonly LoginResponse loginResponse;
        public IMapper mapper;

        public BaseGlobalService(LoginResponse _loginResponse)
        {
            this.loginResponse = _loginResponse;
            SetDbContext();
            mapper = createMapConfig().CreateMapper();
        }
        public BaseGlobalService()
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
            using (CryptoManager engine = new CryptoManager(""))
            {
                globalConnstr = engine.Decrypt(this.loginResponse.globalKey);
            }

            dbContext = new GlobalDataContext(globalConnstr);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
