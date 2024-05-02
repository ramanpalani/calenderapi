using Calendar.Models.Models.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Events.Interface.IBL
{
    public interface IEventBL
    {
        Task<List<Event>> GetAll();
    }
}
