using Calendar.Events.Interface.IBL;
using Calendar.Events.Interface.IRepository.IEvents;
using Calendar.Models.Models.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Events.BL
{
    public class EventBL : IEventBL
    {
        private IEventsRepository  _eventsRepository;
        public EventBL(IEventsRepository eventsRepository)
        {
            _eventsRepository = eventsRepository;
        }
        public Task<List<Event>> GetAll()
        {
            return _eventsRepository.GetAll();
        }
    }
}
