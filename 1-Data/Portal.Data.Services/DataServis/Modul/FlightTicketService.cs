using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Portal.Data.Context;
using Portal.Data.Entities.ClientEntities;
using System.Data;

namespace Portal.Data.Services
{
    public interface IFlightTicketService : IBaseClientService
    {
    }
    public class FlightTicketService : BaseClientService, IFlightTicketService
    {
        public FlightTicketService()
        {
        }
    }
}
