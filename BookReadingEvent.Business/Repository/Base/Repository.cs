using BookReadingEvent.Business.Data;
using BookReadingEvent.Foundation.Entities.Base;
using BookReadingEvent.Foundation.IRepositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReadingEvent.Business.Repository.Base
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly EventContext _eventContext;

        public Repository(EventContext eventContext)
        {
            this._eventContext = eventContext ?? throw new ArgumentNullException(nameof(eventContext)); ;
        }

    }
}
