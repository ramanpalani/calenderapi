using calendar.Events.Interface.IBL;
using Calendar.Repository.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Events.BL
{
    public class GenericBL<T> : IGenericBL<T> where T:class
    {
        private readonly IGenericRepository<object> _dbContext;
        public GenericBL(IGenericRepository<object> genericRepository) 
        {
            _dbContext = genericRepository;
        }

        public async Task<int> GetAll()
        {
            var result = await _dbContext.GetAll();
            return 0;
        }
    }
}
