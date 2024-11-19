using AutoMapper;
using Microsoft.Data.SqlClient;
using Portal.Data.Context;
using Portal.Data.Services;
using Portal.Helpers;
using Portal.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace MioPortal.Data.Services
{
    public interface IClientDefinitionsService : IBaseClientService
    {
        Task<List<SelectItem>> GetTransactionStatusSelectList(int TypeID);
        Task<List<SelectItem>> GetPositionSelectList();
        Task<List<SelectItem>> GetSpecialCodeSelectList(int TypeID);
        Task<object> GetObjectMainListAsync(string Query);
        object GetObjectMainList(string Query);
    }
    public class ClientDefinitionsService : BaseClientService, IClientDefinitionsService
    {
        public ClientDefinitionsService()
        {
        }

        public object GetObjectMainList(string Query)
        {
            using (var connection = new SqlConnection(clientContext.Database.GetConnectionString()))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = Query;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    return dataTable;
                }
            }
        }
        public async Task<object> GetObjectMainListAsync(string Query)
        {
            return await Task.Run(() => GetObjectMainList(Query));
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
