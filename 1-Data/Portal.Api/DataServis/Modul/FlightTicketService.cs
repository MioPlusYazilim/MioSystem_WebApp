using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MioPortal.Api.Data.Entity.ClientEntity;
using Portal.Api.Data.Context;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Api.DataServis
{
    public interface IFlightTicketService : IBaseClientService
    {
        //Task<string> GetFlightTicketWebReportResult(TicketReportRequest model);
        Task<List<FlightTicketWebReportViewResult>> GetFlightTicketWebReportResult(TicketReportRequest model);
    }
    public class FlightTicketService : BaseClientService, IFlightTicketService
    {
        public FlightTicketService(ClientDataContext _cLientContext, GlobalDataContext _globalContext, IMapper _Imapper, ISessionService _sessionServis) : base(_cLientContext, _globalContext, _Imapper, _sessionServis)
        {
        }
        public async Task<List<FlightTicketWebReportViewResult>> GetFlightTicketWebReportResult(TicketReportRequest model)
        {
            var employeParams = clientContext.EmployeeParameters.FirstOrDefault(x => x.EmployeeID == session.EmployeeID);
            string query = "select * from FlightTicketWebReportView where 1=1 ";

            if (string.IsNullOrEmpty(model.reportGlobalParameters.customerIDs) == false)
                query += string.Format(" and prmCustomerID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.customerIDs);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.customerGroupIDs) == false)
                query += string.Format(" and prmCustomerGrupID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.customerIDs);
            if (model.reportGlobalParameters.processDate1 != null)
                query += string.Format("and prmTransactiondate >='{0}'", model.reportGlobalParameters.processDate1.Value.ToString("yyyy-MM-dd"));
            if (model.reportGlobalParameters.processDate2 != null)
                query += string.Format("and prmTransactiondate <='{0}'", model.reportGlobalParameters.processDate2.Value.ToString("yyyy-MM-dd"));
            if (string.IsNullOrEmpty(model.reportGlobalParameters.employeeIDs) == false)
                query += string.Format(" and prmEmployeeID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.employeeIDs);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.issuedBy) == false)
                query += string.Format("and prmRequest ='{0}'", model.reportGlobalParameters.issuedBy);
            if (model.reportGlobalParameters.issueDate1 != null)
                query += string.Format("and prmRequestDate >='{0}'", model.reportGlobalParameters.issueDate1.Value.ToString("yyyy-MM-dd"));
            if (model.reportGlobalParameters.issueDate2 != null)
                query += string.Format("and prmRequestDate <='{0}'", model.reportGlobalParameters.issueDate2.Value.ToString("yyyy-MM-dd"));
            if (model.reportGlobalParameters.reportCurrencyID > 0)
                query += string.Format("and prmCurrencyID ='{0}'", model.reportGlobalParameters.reportCurrencyID);
            if (model.reportGlobalParameters.reportCurrencyRateTypeID > 0)
                query += string.Format("and prmExchangeTypeID ='{0}'", model.reportGlobalParameters.reportCurrencyRateTypeID);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.transactionNumber) == false)
                query += string.Format("and prmTransactionNo ='{0}'", model.reportGlobalParameters.transactionNumber);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.processStatusIDs) == false)
                query += string.Format(" and prmStatusID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.processStatusIDs);
            if(model.reportGlobalParameters.isDomestic>0)
                query += string.Format("and prmIsDomestic ='{0}'", model.reportGlobalParameters.isDomestic);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.employeeDepartmentIDs) == false)
                query += string.Format(" and prmEmployeeDepartmentID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.employeeDepartmentIDs);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.positionIDs) == false)
                query += string.Format(" and prmPositionID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.positionIDs);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.invoiceNubmer)==false)
                query += string.Format("and prmInvoiceNo ='{0}'", model.reportGlobalParameters.invoiceNubmer);
            if (model.reportGlobalParameters.invoiceDate1 != null)
                query += string.Format("and prmInvoiceDate >='{0}'", model.reportGlobalParameters.invoiceDate1.Value.ToString("yyyy-MM-dd"));
            if (model.reportGlobalParameters.invoiceDate2 != null)
                query += string.Format("and prmInvoiceDate <='{0}'", model.reportGlobalParameters.invoiceDate2.Value.ToString("yyyy-MM-dd"));
            if (string.IsNullOrEmpty(model.reportGlobalParameters.specialCode1IDs) == false)
                query += string.Format(" and prmSpecialID1 IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.specialCode1IDs);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.specialCode2IDs) == false)
                query += string.Format(" and prmSpecialID2 IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.specialCode2IDs);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.specialCode3IDs) == false)
                query += string.Format(" and prmSpecialID3 IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.specialCode3IDs);
            if (model.reportCustomerParameters.serviceBeginDate1 != null)
                query += string.Format("and prmBeginDate >='{0}'", model.reportCustomerParameters.serviceBeginDate1.Value.ToString("yyyy-MM-dd"));
            if (model.reportCustomerParameters.serviceBeginDate2 != null)
                query += string.Format("and prmBeginDate <='{0}'", model.reportCustomerParameters.serviceBeginDate2.Value.ToString("yyyy-MM-dd"));
            if (model.reportCustomerParameters.serviceEndDate1 != null)
                query += string.Format("and prmEndDate >='{0}'", model.reportCustomerParameters.serviceEndDate1.Value.ToString("yyyy-MM-dd"));
            if (model.reportCustomerParameters.serviceEndDate2 != null)
                query += string.Format("and prmEndDate <='{0}'", model.reportCustomerParameters.serviceEndDate2.Value.ToString("yyyy-MM-dd"));
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
                query += string.Format("and prmRequestCode ='{0}'", model.reportCustomerParameters.claimCode);
            if (string.IsNullOrEmpty(model.reportCustomerParameters.confirmationCode) == false)
                query += string.Format("and prmApprovalCode ='{0}'", model.reportCustomerParameters.confirmationCode);
            if (string.IsNullOrEmpty(model.flightCabinTypeIDs) == false)
                query += string.Format(" and prmFlightCabinTypeID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.flightCabinTypeIDs);
            if (string.IsNullOrEmpty(model.airlineCodes) == false)
                query += string.Format(" and prmAirLine IN(SELECT myval FROM dbo.Fn_SplitString('{0}', ';'))", model.airlineCodes);
            if (string.IsNullOrEmpty(model.flightDistanceIDs) == false)
                query += string.Format(" and prmFlightLineDistanceID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.flightDistanceIDs);
            if (string.IsNullOrEmpty(model.flightZoneIDs) == false)
                query += string.Format(" and prmFlightLineZoneID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.flightZoneIDs);
            if (string.IsNullOrEmpty(model.flightTicketFeatureIDs) == false)
                query += string.Format(" and prmTicketTypeID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.flightTicketFeatureIDs);
            if (string.IsNullOrEmpty(model.flightDirectionIDs) == false)
                query += string.Format(" and prmFlightDirectionID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.flightDirectionIDs);
            if (string.IsNullOrEmpty(model.fligthTicketStatuses) == false)
                query += string.Format(" and prmTicketStatusTypeID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.fligthTicketStatuses);
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
                return clientContext.FlightTicketWebReportViews.FromSqlRaw(query).Select(s => new FlightTicketWebReportViewResult()
                {
                    Pnr = s.Pnr,
                    TicketNumber = s.TicketNumber,
                    Airline = s.Airline,
                    Destination = s.Destination,
                    FlightDate = s.FlightDate,
                    Status = s.Status,
                    CostCenter = s.CostCenter,
                    CustomerName = s.CustomerName,
                    IssuedBy = s.IssuedBy,
                    Passenger = s.Passenger,
                    Project = s.Project,
                    SaleDate = s.SaleDate,
                    TicketCost = s.TicketCost,
                    InvoiceDate = s.InvoiceDate,
                    InvoiceNumber = s.InvoiceNumber   
                    
                }).ToList();
                //DataTable dataTable = new DataTable();
                //using (SqlConnection conn = new SqlConnection(clientContext.Database.GetConnectionString()))
                //{
                //    using (SqlCommand cmd = conn.CreateCommand())
                //    {
                //        cmd.CommandType = System.Data.CommandType.Text;
                //        cmd.CommandText = query;
                //        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                //        {
                            
                //            adapter.Fill(dataTable);
                //        }
                //    }
                //}
                //for (int col = dataTable.Columns.Count - 1; col >= 0; col--)
                //{
                //    if (dataTable.Columns[col].ColumnName.StartsWith("prm"))
                //    {
                //        dataTable.Columns.RemoveAt(col);
                //    }
                //}
                //return Newtonsoft.Json.JsonConvert.SerializeObject(dataTable);
            });
        }
    }
}
