using AutoMapper;
using Portal.Model.Utils;
using Portal.Api.Data.Context;
using Portal.Api.DataServis;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MioPortal.Api.DataServis
{
    public interface IClientDefinitionsService : IBaseClientService
    {
        Task<List<SelectItem>> GetTransactionStatusSelectList(int TypeID);
        Task<List<SelectItem>> GetPositionSelectList();
        Task<List<SelectItem>> GetSpecialCodeSelectList(int TypeID);
    }
    public class ClientDefinitionsService : BaseClientService, IClientDefinitionsService
    {
        public ClientDefinitionsService(ClientDataContext _cLientContext, GlobalDataContext _globalContext, IMapper _Imapper, ISessionService _sessionServis) : base(_cLientContext, _globalContext, _Imapper, _sessionServis)
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
