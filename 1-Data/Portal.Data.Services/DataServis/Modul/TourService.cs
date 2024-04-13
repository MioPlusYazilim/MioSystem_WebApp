using AutoMapper;
using Portal.Data.Context;
using Portal.Model;

namespace Portal.Data.Services
{
    public interface ITourService : IBaseClientService
    {
    }
    public class TourService : BaseClientService, ITourService
    {
        public TourService()
        {
        }
    }
}
