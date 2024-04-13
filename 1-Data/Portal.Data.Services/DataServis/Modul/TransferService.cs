using AutoMapper;
using Portal.Data.Context;
using Portal.Model;

namespace Portal.Data.Services
{
    public interface ITransferService : IBaseClientService
    {
    }
    public class TransferService : BaseClientService, ITransferService
    {
        public TransferService()
        {
        }
    }
}
