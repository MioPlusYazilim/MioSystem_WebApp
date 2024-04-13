using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MioPortal.Api.Data.Entity.ClientEntity;
using Portal.Model.Utils;
using Portal.Api.Data.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Api.DataServis
{
    public interface IAccountService : IBaseClientService
    {
        Task<List<SelectItem>> GetCustomerSelectList(int TypeID);
        Task<List<SelectItem>> GetCustomerProjectSelectList();
        Task<List<SelectItem>> GetCustomerCorporateSelectList(int TypeID);
        Task<List<SelectItem>> GetCustomersGroupSelectList();
        Task<List<SelectItem>> GetCurrencySelectList();
        Task<List<SelectItem>> GetCurrencyRateTypeSelectList();
        Task<List<SelectItem>> GetSupplierChainSelectList();

        Task<object> GetInvoiceWebReportResult(InvoiceReportRequest model);
        Task<object> GetInvoiceCheckResult(InvoiceCheckRequest model);
        Task<object> GetModulWebReportResult(ModuleReportRequest model);
        Task<string> GetWebReportMounthlyDashBoardResult();
        Task<string> GetWebReportDailyTransactionResult();


    }
    public class AccountService : BaseClientService, IAccountService
    {
        public AccountService(ClientDataContext _cLientContext, GlobalDataContext _globalContext, IMapper _Imapper, ISessionService _sessionServis) : base(_cLientContext, _globalContext, _Imapper, _sessionServis)
        {
        }

        public async Task<List<SelectItem>> GetCustomerProjectSelectList()
        {
            return await Task.Run(() => clientContext
                                        .CustomerProjectSelectViews
                                        .Where(x => session.AuthoryGroup == 1 ? true : (session.CustomerIDs.Contains(x.ID) || session.CustomerGroupIDs.Contains(x.GroupID)))
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code= s.Code,
                                            name= s.Name
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetCustomerSelectList(int TypeID)
        {
            return await Task.Run(() => clientContext
                                        .CustomerSelectViews
                                        .Where(x => x.TypeID==TypeID && session.AuthoryGroup == 1 ? true :(session.CustomerIDs.Contains(x.ID)|| session.CustomerGroupIDs.Contains(x.GroupID)))
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            name = s.FullName
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetCustomersGroupSelectList()
        {
            return await Task.Run(() => clientContext
                                        .CustomerGroupSelectViews
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.Code,
                                            name= s.FullName
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetCustomerCorporateSelectList(int TypeID)
        {
            return await Task.Run(() => clientContext
                                        .CustomerCorporateSelectViews
                                        .Where(x => x.TypeID == TypeID 
                                                  && session.AuthoryGroup == 1 ? true :(session.CustomerIDs.Contains(x.CustomerID) || session.CustomerGroupIDs.Contains(x.CustomerGroupID))
                                                  && session.AuthoryLevel <= 2 ? x.ID==session.DepartmentID: true
                                          )
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.Code,
                                            name = s.FullName
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetCurrencySelectList()
        {
            return await Task.Run(() => globalContext
                                        .Currencies
                                        .Where(x => x.LanguageCode == session.Language)
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.FieldValue,
                                            name = s.FieldName
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetCurrencyRateTypeSelectList()
        {
            return await Task.Run(() => globalContext
                                        .CurrencyRateTypes
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.FieldValue,
                                            name = s.FieldName
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetSupplierChainSelectList()
        {
            return await Task.Run(() => clientContext
                                        .SupplierChains
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.Code,
                                            name = s.CodeName
                                        }).ToList());
        }

        public async Task<object> GetInvoiceWebReportResult(InvoiceReportRequest model)
        {
            var employeParams = clientContext.EmployeeParameters.FirstOrDefault(x => x.EmployeeID == session.EmployeeID);
            string query = "select * from InvoiceWebReportView where 1=1 ";

            if (string.IsNullOrEmpty(model.customerIDs) == false)
                query += string.Format(" and prmCustomerID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.customerIDs);
            if (string.IsNullOrEmpty(model.customerGroupIDs) == false)
                query += string.Format(" and prmCustomerGroupID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.customerGroupIDs);
            if (model.invoiceDateBegin != null)
                query += string.Format("and InvoiceDate >='{0}'", model.invoiceDateBegin.Value.ToString("yyyy-MM-dd"));
            if (model.invoiceDateEnd != null)
                query += string.Format("and InvoiceDate <='{0}'", model.invoiceDateEnd.Value.ToString("yyyy-MM-dd"));
            if (model.expiryDateBegin != null)
                query += string.Format("and ExpryDate >='{0}'", model.expiryDateBegin.Value.ToString("yyyy-MM-dd"));
            if (model.expiryDateEnd != null)
                query += string.Format("and ExpryDate <='{0}'", model.expiryDateEnd.Value.ToString("yyyy-MM-dd"));
            if (string.IsNullOrEmpty(model.invoiceGroupIDs) == false)
                query += string.Format(" and prmInvoiceGroupID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.invoiceGroupIDs);
            if (string.IsNullOrEmpty(model.invoiceTypeIDs) == false)
                query += string.Format(" and prmInvoiceTypeID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.invoiceTypeIDs);
            if (string.IsNullOrEmpty(model.personelIDs) == false)
                query += string.Format(" and prmEmployeeID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.personelIDs);
            if (string.IsNullOrEmpty(model.positionIDs) == false)
                query += string.Format(" and prmPositionID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.positionIDs);
            if (model.currencyID >0)
                query += string.Format(" and prmCurrencyID ='{0}'", model.currencyID);

            // s.costCenterIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
            if (session.AuthoryGroup == 2)
            {
                query += string.Format(" and (prmCustomerID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", employeParams.AuthorizedCustomerIDs);
                if (string.IsNullOrEmpty(employeParams.AuthorizedCustomerGroupIDs) == false)
                    query += string.Format(" or prmCustomerGroupID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';')))", employeParams.AuthorizedCustomerGroupIDs);
                else
                    query += ")";

                if (session.AuthoryLevel == 1)
                    query += string.Format(" and prmCustomerEmployeeID ='{0}'", session.EmployeeID);
                if (session.AuthoryLevel == 2)
                    query += string.Format(" and prmCustomerDepartmentID ='{0}'", session.DepartmentID);
            }

            return await Task.Run(() =>
            {
                return clientContext.InvoiceWebReportViews.FromSqlRaw(query).Select(s => new
                {
                    s.TransactionNo,
                    s.InvoiceGroup,
                    s.InvoiceNumber,
                    s.InvoiceDate,
                    s.ExpryDate,
                    s.InvoiceTypeKind,
                    s.InvoiceType,
                    s.Customer,
                    s.Position,
                    s.Employee,
                    s.Total,
                    s.Tax,
                    s.GrnadTotal
                }).ToList();
            });
        }
        public async Task<object> GetInvoiceCheckResult(InvoiceCheckRequest model)
        {
            var employeParams = clientContext.EmployeeParameters.FirstOrDefault(x => x.EmployeeID == session.EmployeeID);
            string query = "select * from CustomerInvoiceCheckView where 1=1 ";

            if (model.processDate1 != null)
                query += string.Format("and transactionDate >='{0}'", model.processDate1.Value.ToString("yyyy-MM-dd"));
            if (model.processDate2 != null)
                query += string.Format("and transactionDate <='{0}'", model.processDate2.Value.ToString("yyyy-MM-dd"));
            if (model.serviceBeginDate1 != null)
                query += string.Format("and serviceBeginDate >='{0}'", model.serviceBeginDate1.Value.ToString("yyyy-MM-dd"));
            if (model.serviceBeginDate2 != null)
                query += string.Format("and serviceBeginDate <='{0}'", model.serviceBeginDate2.Value.ToString("yyyy-MM-dd"));
            if (model.serviceEndDate1 != null)
                query += string.Format("and serviceEndDate >='{0}'", model.serviceEndDate1.Value.ToString("yyyy-MM-dd"));
            if (model.serviceBeginDate2 != null)
                query += string.Format("and serviceEndDate <='{0}'", model.serviceBeginDate2.Value.ToString("yyyy-MM-dd"));
            if (model.isDomestic > 0)
                query += string.Format("and prmIsDomestic ='{0}'", model.isDomestic);
            if (string.IsNullOrEmpty(model.moduleIDs) == false)
                query += string.Format(" and prmEmployeeModulID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.moduleIDs);
            if (string.IsNullOrEmpty(model.issuedBy) == false)
                query += string.Format("and issuedBy like'%{0}%'", model.issuedBy);
            if (string.IsNullOrEmpty(model.costCenter) == false)
                query += string.Format("and costCenter like'%{0}%'", model.costCenter);
            if (string.IsNullOrEmpty(model.requestCode) == false)
                query += string.Format("and requestCode like'%{0}%'", model.requestCode);
            if (string.IsNullOrEmpty(model.confirmationCode) == false)
                query += string.Format("and conrifmationCode like'%{0}%'", model.confirmationCode);

            // s.costCenterIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
            if (session.AuthoryGroup == 2)
            {
                query += string.Format(" and (prmCustomerID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", employeParams.AuthorizedCustomerIDs);
                if (string.IsNullOrEmpty(employeParams.AuthorizedCustomerGroupIDs) == false)
                    query += string.Format(" or prmCustomerGroupID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';')))", employeParams.AuthorizedCustomerGroupIDs);
                else
                    query += ")";

                if (session.AuthoryLevel == 1)
                    query += string.Format(" and prmCustomerEmployeeID ='{0}'", session.EmployeeID);
                if (session.AuthoryLevel == 2)
                    query += string.Format(" and prmCustomerDepartmentID ='{0}'", session.DepartmentID);
            }

            return await Task.Run(() =>
            {
                return clientContext.InvoiceCheckViews.FromSqlRaw(query).Select(s => new
                {
                    select ="",
                    s.statusCode,
                    s.reasonCode,
                    s.invoiceNote,
                    s.institutionalNote,
                    s.issuedBy,
                    s.requestCode,
                    s.conrifmationCode,
                    s.invoiceModel,
                    s.transactionDate,
                    s.transactionNumber,
                    s.serviceBeginDate,
                    s.serviceEndDate,
                    s.passengerName,
                    s.costCenter,
                    s.currency,
                    s.currencyRate,
                    s.total,
                    s.vatInclude,
                    s.vatRate,
                    s.vatTotal,
                    s.notInvoiced,
                    s.notInvoicedTL,
                }).ToList();
            });
        }
        public async Task<object> GetModulWebReportResult(ModuleReportRequest model)
        {
            var employeParams = clientContext.EmployeeParameters.FirstOrDefault(x => x.EmployeeID == session.EmployeeID);
            string query = "select * from ModulWebReportView where 1=1 ";

            if (string.IsNullOrEmpty(model.reportGlobalParameters.customerIDs) == false)
                query += string.Format(" and prmCustomerID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.customerIDs);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.customerGroupIDs) == false)
                query += string.Format(" and prmCustomerGroupID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.customerIDs);
            if (model.reportGlobalParameters.processDate1 != null)
                query += string.Format("and Transactiondate >='{0}'", model.reportGlobalParameters.processDate1.Value.ToString("yyyy-MM-dd"));
            if (model.reportGlobalParameters.processDate2 != null)
                query += string.Format("and Transactiondate <='{0}'", model.reportGlobalParameters.processDate2.Value.ToString("yyyy-MM-dd"));
            if (string.IsNullOrEmpty(model.reportGlobalParameters.employeeIDs) == false)
                query += string.Format(" and prmEmployeeID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.employeeIDs);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.issuedBy) == false)
                query += string.Format("and prmIssuedBy ='{0}'", model.reportGlobalParameters.issuedBy);
            if (model.reportGlobalParameters.issueDate1 != null)
                query += string.Format("and prmIssueDate >='{0}'", model.reportGlobalParameters.issueDate1.Value.ToString("yyyy-MM-dd"));
            if (model.reportGlobalParameters.issueDate2 != null)
                query += string.Format("and prmIssueDate <='{0}'", model.reportGlobalParameters.issueDate2.Value.ToString("yyyy-MM-dd"));
            if (model.reportGlobalParameters.reportCurrencyID > 0)
                query += string.Format("and prmCurrencyID ='{0}'", model.reportGlobalParameters.reportCurrencyID);
            if (model.reportGlobalParameters.reportCurrencyRateTypeID > 0)
                query += string.Format("and prmExchangeTypeID ='{0}'", model.reportGlobalParameters.reportCurrencyRateTypeID);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.transactionNumber) == false)
                query += string.Format("and TransactionNo ='{0}'", model.reportGlobalParameters.transactionNumber);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.processStatusIDs) == false)
                query += string.Format(" and prmStatusID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.processStatusIDs);
            if (model.reportGlobalParameters.isDomestic > 0)
                query += string.Format("and prmIsDomestic ='{0}'", model.reportGlobalParameters.isDomestic);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.employeeDepartmentIDs) == false)
                query += string.Format(" and prmEmployeeDepartmentID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.employeeDepartmentIDs);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.positionIDs) == false)
                query += string.Format(" and prmPositionID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.positionIDs);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.invoiceNubmer) == false)
                query += string.Format("and InvoiceNumber ='{0}'", model.reportGlobalParameters.invoiceNubmer);
            if (model.reportGlobalParameters.invoiceDate1 != null)
                query += string.Format("and InvoiceDate >='{0}'", model.reportGlobalParameters.invoiceDate1.Value.ToString("yyyy-MM-dd"));
            if (model.reportGlobalParameters.invoiceDate2 != null)
                query += string.Format("and InvoiceDate <='{0}'", model.reportGlobalParameters.invoiceDate2.Value.ToString("yyyy-MM-dd"));
            if (string.IsNullOrEmpty(model.reportGlobalParameters.specialCode1IDs) == false)
                query += string.Format(" and prmSpecialID1 IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.specialCode1IDs);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.specialCode2IDs) == false)
                query += string.Format(" and prmSpecialID2 IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.specialCode2IDs);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.specialCode3IDs) == false)
                query += string.Format(" and prmSpecialID3 IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.specialCode3IDs);
            if (model.reportCustomerParameters.serviceBeginDate1 != null)
                query += string.Format("and ServiceBegin >='{0}'", model.reportCustomerParameters.serviceBeginDate1.Value.ToString("yyyy-MM-dd"));
            if (model.reportCustomerParameters.serviceBeginDate2 != null)
                query += string.Format("and ServiceBegin <='{0}'", model.reportCustomerParameters.serviceBeginDate2.Value.ToString("yyyy-MM-dd"));
            if (model.reportCustomerParameters.serviceEndDate1 != null)
                query += string.Format("and ServiceEnd >='{0}'", model.reportCustomerParameters.serviceEndDate1.Value.ToString("yyyy-MM-dd"));
            if (model.reportCustomerParameters.serviceEndDate2 != null)
                query += string.Format("and ServiceEnd <='{0}'", model.reportCustomerParameters.serviceEndDate2.Value.ToString("yyyy-MM-dd"));
            if (string.IsNullOrEmpty(model.reportCustomerParameters.paymentTypeIDs) == false)
                query += string.Format(" and prmPaymentTypeID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportCustomerParameters.paymentTypeIDs);
            if (string.IsNullOrEmpty(model.reportCustomerParameters.customerEmployeeTypeIDs) == false)
                query += string.Format(" and prmPassengerTypeID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportCustomerParameters.customerEmployeeTypeIDs);
            if (string.IsNullOrEmpty(model.reportCustomerParameters.customerDepartmentIDs) == false)
                query += string.Format(" and prmCustomerDepartmentID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportCustomerParameters.customerDepartmentIDs);
            if (string.IsNullOrEmpty(model.reportCustomerParameters.projectIDs) == false)
                query += string.Format(" and prmCustomerCostCenterID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportCustomerParameters.projectIDs);
            if (string.IsNullOrEmpty(model.reportCustomerParameters.reasonIDs) == false)
                query += string.Format(" and prmReasonCode IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportCustomerParameters.reasonIDs);
            if (string.IsNullOrEmpty(model.reportCustomerParameters.passengerClassIDs) == false)
                query += string.Format(" and prmPassengerClassTypeID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportCustomerParameters.passengerClassIDs);
            if (string.IsNullOrEmpty(model.reportCustomerParameters.sectionIDs) == false)
                query += string.Format(" and prmCustomerSectionID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportCustomerParameters.sectionIDs);
            if (string.IsNullOrEmpty(model.reportCustomerParameters.locationIDs) == false)
                query += string.Format(" and prmCustomerLocationID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportCustomerParameters.locationIDs);
            if (string.IsNullOrEmpty(model.reportCustomerParameters.claimCode) == false)
                query += string.Format("and ClaimCode ='{0}'", model.reportCustomerParameters.claimCode);
            if (string.IsNullOrEmpty(model.reportCustomerParameters.confirmationCode) == false)
                query += string.Format("and ConfirmationCode ='{0}'", model.reportCustomerParameters.confirmationCode);
            if (string.IsNullOrEmpty(model.reportCustomerParameters.customerEmployeeIDs) == false)
                query += string.Format(" and prmCustomerEmployeeID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportCustomerParameters.customerEmployeeIDs);

            if (session.AuthoryGroup == 2)
            {
                query += string.Format(" and (prmCustomerID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", employeParams.AuthorizedCustomerIDs);
                if (string.IsNullOrEmpty(employeParams.AuthorizedCustomerGroupIDs) == false)
                    query += string.Format(" or prmCustomerGroupID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';')))", employeParams.AuthorizedCustomerGroupIDs);
                else
                    query += ")";

                if (session.AuthoryLevel == 1)
                    query += string.Format(" and prmCustomerEmployeeID ='{0}'", session.EmployeeID);
                if (session.AuthoryLevel == 2)
                    query += string.Format(" and prmCustomerDepartmentID ='{0}'", session.DepartmentID);
            }

            return await Task.Run(() =>
            {
                return clientContext.ModulWebReportViews.FromSqlRaw(query).Select(s => new
                {
                    s.Module,
                    s.IsDomestic,
                    s.Transactiondate,
                    s.TransactionNo,
                    s.PassengerName,
                    s.CustomerName,
                    s.ServiceBegin,
                    s.ServiceEnd,
                    s.Supplier,
                    s.CostCenter,
                    s.IssuedBy,
                    s.ClaimCode,
                    s.ConfirmationCode,
                    s.Status,
                    s.SaleTotal,
                    s.Employee,
                    s.PositionCode,
                    s.InvoiceDate,
                    s.InvoiceNumber,
                    s.Department,
                }).ToList();
            });
        }

        public async Task<string> GetWebReportMounthlyDashBoardResult()
        {
            var employeParams = clientContext.EmployeeParameters.FirstOrDefault(x => x.EmployeeID == session.EmployeeID);
            string query = "select * from MainDashBoardView where 1=1 ";

            if (session.AuthoryGroup == 2)
            {
                query += string.Format(" and (prmCustomerID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", employeParams.AuthorizedCustomerIDs);
                if (string.IsNullOrEmpty(employeParams.AuthorizedCustomerGroupIDs) == false)
                    query += string.Format(" or prmCustomerGroupID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';')))", employeParams.AuthorizedCustomerGroupIDs);
                else
                    query += ")";

                if (session.AuthoryLevel == 1)
                    query += string.Format(" and prmCustomerEmployeeID ='{0}'", session.EmployeeID);
                if (session.AuthoryLevel == 2)
                    query += string.Format(" and prmCustomerDepartmentID ='{0}'", session.DepartmentID);
            }

            return await Task.Run(() =>
            {
                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(clientContext.Database.GetConnectionString()))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            adapter.Fill(dataTable);
                        }
                    }
                }
                for (int col = dataTable.Columns.Count - 1; col >= 0; col--)
                {
                    if (dataTable.Columns[col].ColumnName.StartsWith("prm"))
                    {
                        dataTable.Columns.RemoveAt(col);
                    }
                }
                return Newtonsoft.Json.JsonConvert.SerializeObject(dataTable);
            });
        }
        public async Task<string> GetWebReportDailyTransactionResult()
        {
            var employeParams = clientContext.EmployeeParameters.FirstOrDefault(x => x.EmployeeID == session.EmployeeID);
            string query = "select top 100 * from ModulLastTransactionView where 1=1 ";

            if (session.AuthoryGroup == 2)
            {
                query += string.Format(" and (prmCustomerID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", employeParams.AuthorizedCustomerIDs);
                if (string.IsNullOrEmpty(employeParams.AuthorizedCustomerGroupIDs) == false)
                    query += string.Format(" or prmCustomerGroupID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';')))", employeParams.AuthorizedCustomerGroupIDs);
                else
                    query += ")";

                if (session.AuthoryLevel == 1)
                    query += string.Format(" and prmCustomerEmployeeID ='{0}'", session.EmployeeID);
                if (session.AuthoryLevel == 2)
                    query += string.Format(" and prmCustomerDepartmentID ='{0}'", session.DepartmentID);
            }
            query += " order by [DepartureDate] desc";
            return await Task.Run(() =>
            {
                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(clientContext.Database.GetConnectionString()))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            adapter.Fill(dataTable);
                        }
                    }
                }
                for (int col = dataTable.Columns.Count - 1; col >= 0; col--)
                {
                    if (dataTable.Columns[col].ColumnName.StartsWith("prm"))
                    {
                        dataTable.Columns.RemoveAt(col);
                    }
                }
                return Newtonsoft.Json.JsonConvert.SerializeObject(dataTable);
            });
        }
    }
}
