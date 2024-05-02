using Calendar.Models.Models.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Events.Interface.Iservice
{
    public interface IEventService
    {
        Task<List<Event>> Getall();
    }
}
