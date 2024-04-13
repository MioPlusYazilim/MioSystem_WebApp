using AutoMapper;
using Portal.Data.Context;
using Portal.Model;

namespace Portal.Data.Services
{
    public interface IVisaService : IBaseClientService
    {
    }
    public class VisaService : BaseClientService, IVisaService
    {
        public VisaService()
        {
        }
    }
}
