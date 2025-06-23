using AutoMapper;
using Portal.Data.Services.Base;
using Portal.Data.Context;
using Portal.Helpers;
using Portal.Model;
using Portal.Data.Entities.GlobalEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Portal.Data.Services.GlobalContextService;


namespace Portal.Data.Services.DataServis.ClientContextService
{
    public interface IClientContextService : IBaseClientService
    {
        List<SelectItem> GetAirlineServiceSelectList(string LengCode);
        Task<List<SelectItem>> GetAirlineServiceSelectListAsync(string LengCode);
    }

    //public class ClientContextService : BaseClientService, IClientContextService
    //{
    //    public ClientContextService()
    //    {
    //    }

    //    public List<SelectItem> GetAirLineSelectList(string LengCode)
    //    {
    //        return clientContext.AirlineService.AsNoTracking()
    //                                 .Where(x => x.LanguageCode == LengCode)
    //                                 .Select(s => new SelectItem()
    //                                 {
    //                                     value = s.ID,
    //                                     code = s.FieldValue,
    //                                     name = s.FieldName
    //                                 })
    //                                 .ToList();
    //    }
    //    public async Task<List<SelectItem>> GetAirLineSelectListAsync(string LengCode)
    //    {
    //        return await Task.Run(() => GetAirLineSelectList(LengCode));
    //    }

    //}
}
