using BookReadingEvent.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReadingEvent.Core.IRepositories.Base
{
    public interface IRepository<T> where T : Entity
    {

    }
}
