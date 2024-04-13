using AutoMapper;
using Portal.Data.Context;
using Portal.Model;

namespace Portal.Data.Services
{
    public interface IOtherProcessService : IBaseClientService
    {
    }
    public class OtherProcessService : BaseClientService, IOtherProcessService
    {
        public OtherProcessService()
        {
        }
    }
}
