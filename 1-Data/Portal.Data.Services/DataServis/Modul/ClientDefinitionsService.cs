using AutoMapper;
using Portal.Data.Context;
using Portal.Data.Services;
using Portal.Helpers;
using Portal.Model;

namespace MioPortal.Data.Services
{
    public interface IClientDefinitionsService : IBaseClientService
    {
        Task<List<SelectItem>> GetTransactionStatusSelectList(int TypeID);
        Task<List<SelectItem>> GetPositionSelectList();
        Task<List<SelectItem>> GetSpecialCodeSelectList(int TypeID);
    }
    public class ClientDefinitionsService : BaseClientService, IClientDefinitionsService
    {
        public ClientDefinitionsService()
        {
        }

        public async Task<List<SelectItem>> GetTransactionStatusSelectList(int TypeID)
        {
            return await Task.Run(() => clientContext
                                        .TransactionStatusSelectViews
                                        .Where(x => x.ModulID == TypeID)
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.Code,
                                            name = s.Name,
                                            text = s.FullName
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetPositionSelectList()
        {
            return await Task.Run(() => clientContext
                                        .PositionSelectViews
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.Code,
                                            name = s.FullName
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetSpecialCodeSelectList(int TypeID)
        {
            return await Task.Run(() => clientContext
                                        .SpecialCodeSelectViews
                                        .Where(x => x.TypeID == TypeID)
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.Code,
                                            name = s.FullName
                                        }).ToList());
        }
    }
}
