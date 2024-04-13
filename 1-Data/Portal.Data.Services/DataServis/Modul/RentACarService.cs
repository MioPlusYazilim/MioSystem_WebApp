using AutoMapper;
using Portal.Data.Context;
using Portal.Model;

namespace Portal.Data.Services
{
    public interface IRentACarService : IBaseClientService
    {
    }
    public class RentACarService : BaseClientService, IRentACarService
    {
        public RentACarService()
        {
        }
    }
}
