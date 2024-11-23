using AutoMapper;
using Portal.Data.Entities.ClientEntities;
using Portal.Model;

namespace Portal.Api.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, Employee_Model>().ReverseMap();
            CreateMap<EmployeeAuthorization, EmployeeAuthory_Model>().ReverseMap();
            CreateMap<EmployeeSystemCode, EmployeeSystemCode_Model>().ReverseMap();

            CreateMap<RoleAuthory, RoleAuthory_Model>().ReverseMap();
            CreateMap<RoleAuthoryPermission, RoleAuthoryPermission_Model>().ReverseMap();


            //CreateMap<Company, Company_Model>().ReverseMap();
            //CreateMap<Company_Accounting, Company_Accounting_Model>().ReverseMap();
            //CreateMap<Company_MapLogo, Company_MapLogo_Model>().ReverseMap();
            //CreateMap<Company_Parameter, Company_Parameter_Model>().ReverseMap();
            //CreateMap<Currency, Currency_Model>().ReverseMap();
            //CreateMap<Currency_Rate, Currency_Rate_Model>().ReverseMap();
            //CreateMap<Profession, Profession_Model>().ReverseMap();
            //CreateMap<Customer, Customer_Model>().ReverseMap();
            //CreateMap<Customer_Accounting, Customer_Accounting_Model>().ReverseMap();
            //CreateMap<Customer_MapLogo, Customer_MapLogo_Model>().ReverseMap();
            //CreateMap<Customer_CorporateDefinition, Customer_CorporateDefinition_Model>().ReverseMap();
            //CreateMap<Customer_Parameter, Customer_Parameter_Model>().ReverseMap();
            //CreateMap<Customer_InvoiceDefinition, Customer_InvoiceDefinition_Model>().ReverseMap();
            //CreateMap<Customer_InstructionDefinition, Customer_InstructionDefinition_Model>().ReverseMap();
            //CreateMap<Customer_OtherSystemCode, Customer_OtherSystemCode_Model>().ReverseMap();
            //CreateMap<Customer_Document, Customer_Document_Model>().ReverseMap();
            //CreateMap<CustomerGroup, CustomerGroup_Model>().ReverseMap();
            //CreateMap<CustomerServiceFee, CustomerServiceFee_Model>().ReverseMap();
            //CreateMap<AirLine, AirLine_Model>().ReverseMap();
            //CreateMap<AirPort, AirPort_Model>().ReverseMap();
            //CreateMap<AirPort_Distance, AirPort_Distance_Model>().ReverseMap();

        }
    }
}
