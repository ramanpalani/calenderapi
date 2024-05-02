using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendar.Events.Interface.IBL
{
    public interface IGenericBL<T> where T : class
    {
        Task<int> GetAll();
    }
}
