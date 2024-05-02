using Calendar.Events.Interface.IRepository.IEvents;
using Calendar.Models.Models.Events;
using Calendar.Repository.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calendar.Repository.Repository.Events
{
    public class EventsRepository : IEventsRepository
    {
        private readonly IGenericRepository<Event> Context;
        public EventsRepository(IGenericRepository<Event> genericRepository)
        {
            this.Context = genericRepository;
        }

        public async Task<List<Event>> GetAll()
        {
            var result = await Context.GetAll();
            return result;
        }
    }
}
