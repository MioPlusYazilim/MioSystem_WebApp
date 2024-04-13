using AutoMapper;
using Portal.Data.Context;
using Portal.Model;

namespace Portal.Data.Services
{
    public interface IOrganisationService : IBaseClientService
    {
    }
    public class OrganisationService : BaseClientService, IOrganisationService
    {
        public OrganisationService()
        { 
        }
    }
}
