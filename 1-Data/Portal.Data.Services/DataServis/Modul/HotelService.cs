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
    }
    public class HotelService : BaseClientService, IHotelService
    {
        public HotelService()
        {
        }
    }
}
