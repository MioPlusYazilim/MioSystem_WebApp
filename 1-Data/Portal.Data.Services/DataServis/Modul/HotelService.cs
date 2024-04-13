using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Portal.Data.Context;
using Portal.Data.Entities.ClientEntities;
using Portal.Model;
using System.Data;

namespace Portal.Data.Services
{
    public interface IHotelService : IBaseClientService
    {
        Task<List<HotelWebReportViewResult>> GetHotelWebReportResult(OtelReportRequest model);
    }
    public class HotelService : BaseClientService, IHotelService
    {
        public HotelService()
        {
        }

        public async Task<List<HotelWebReportViewResult>> GetHotelWebReportResult(OtelReportRequest model)
        {
            var employeParams = clientContext.EmployeeParameters.FirstOrDefault(x => x.EmployeeID == loginResponse.employeeID);
            string query = "select * from HotelWebReportView where 1=1 ";
            if (string.IsNullOrEmpty(model.reportGlobalParameters.customerIDs) == false)
                query += string.Format(" and prmCustomerID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.customerIDs);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.customerGroupIDs) == false)
                query += string.Format(" and prmCustomerGroupID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.customerIDs);
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
            if (model.reportGlobalParameters.isDomestic > 0)
                query += string.Format("and prmIsDomestic ='{0}'", model.reportGlobalParameters.isDomestic);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.employeeDepartmentIDs) == false)
                query += string.Format(" and prmEmployeeDepartmentID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.employeeDepartmentIDs);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.positionIDs) == false)
                query += string.Format(" and prmPositionID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportGlobalParameters.positionIDs);
            if (string.IsNullOrEmpty(model.reportGlobalParameters.invoiceNubmer) == false)
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
            if (string.IsNullOrEmpty(model.reportCustomerParameters.customerEmployeeIDs) == false)
                query += string.Format(" and prmCustomerEmployeeID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.reportCustomerParameters.customerEmployeeIDs);

            if (string.IsNullOrEmpty(model.hotelIDs) == false)
                query += string.Format(" and prmHotelID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.hotelIDs);
            if (string.IsNullOrEmpty(model.supplierIDs) == false)
                query += string.Format(" and prmSupplierID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.supplierIDs);
            if (string.IsNullOrEmpty(model.bedTypeIDs) == false)
                query += string.Format(" and prmRoomKindID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.bedTypeIDs);
            if (string.IsNullOrEmpty(model.roomTypeIDs) == false)
                query += string.Format(" and prmRoomTypeID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.roomTypeIDs);
            if (string.IsNullOrEmpty(model.hostelTypeIDs) == false)
                query += string.Format(" and prmPansionTypeID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.hostelTypeIDs);
            if (string.IsNullOrEmpty(model.hotelLocationIDs) == false)
                query += string.Format(" and prmHotelLocationID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.hotelLocationIDs);
            if (string.IsNullOrEmpty(model.hotelSupplierChainIDs) == false)
                query += string.Format(" and prmHotelChainID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.hotelSupplierChainIDs);

            if (string.IsNullOrEmpty(model.confirmationNumber) == false)
                query += string.Format("and prmConfirmeNo ='{0}'", model.confirmationNumber);
            if (string.IsNullOrEmpty(model.voucherNnumber) == false)
                query += string.Format("and prmVoucherNo ='{0}'", model.voucherNnumber);

            if (string.IsNullOrEmpty(model.hotelpaymentTypeIDs) == false)
                query += string.Format(" and prmPayerTypeID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", model.hotelpaymentTypeIDs);


            if (loginResponse.authoryGroup == 2)
            {
                query += string.Format(" and (prmCustomerID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';'))", employeParams.AuthorizedCustomerIDs);
                if (string.IsNullOrEmpty(employeParams.AuthorizedCustomerGroupIDs) == false)
                    query += string.Format(" or prmCustomerGroupID IN(SELECT myval FROM dbo.Fn_SplitInteger('{0}', ';')))", employeParams.AuthorizedCustomerGroupIDs);
                else
                    query += ")";

                if (loginResponse.authoryLevel == 1)
                    query += string.Format(" and prmCustomerEmployeeID ='{0}'", loginResponse.employeeID);
                if (loginResponse.authoryLevel == 2)
                    query += string.Format(" and prmCustomerDepartmentID ='{0}'", loginResponse.departmentID);
            }

            return await Task.Run(() =>
            {
                return clientContext.HotelWebReportViews.FromSqlRaw(query).Select(s => new HotelWebReportViewResult()
                {
                    TransactionNo=s.TransactionNo,
                    SaleDate=s.SaleDate,
                    PassengerName=s.PassengerName,
                    HotelName=s.HotelName,
                    CheckInDate=s.CheckInDate,
                    CheckOutDate=s.CheckOutDate,
                    Night=s.Night,
                    Location=s.Location,
                    Status=s.Status,
                    Notes=s.Notes,
                    IssuedBy=s.IssuedBy,
                    Project =s.Project,
                    Currency=s.Currency,
                    Price=s.Price,
                    LocalCurrencyPrice=s.LocalCurrencyPrice,
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
