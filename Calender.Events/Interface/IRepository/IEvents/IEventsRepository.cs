using Calendar.Models.Models.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Events.Interface.IRepository.IEvents
{
    public interface IEventsRepository
    {
        Task<List<Event>> GetAll();
    }
}
