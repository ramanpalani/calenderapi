using Calendar.Events.Interface.IBL;
using Calendar.Events.Interface.Iservice;
using Calendar.Models.Models.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Events.Services
{
    public class EventService:IEventService
    {
        private readonly IEventBL _eventBL;

        public EventService(IEventBL eventBL)
        {
            _eventBL = eventBL;
        }
        public Task<List<Event>> Getall()
        {
            var result = _eventBL.GetAll();
            return result;
        }


    }
}
