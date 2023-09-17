using BookReadingEvent.Foundation.Entities;
using BookReadingEvent.Foundation.IRepositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReadingEvent.Foundation.IRepositories
{
    public interface IEventRepository : IRepository<Event>
    {
        Task<IList<Event>> GetEvents();
        Task<Event> ViewDetails(int eventId);
        Task<int> CreateEvent(Event _event);

        int UpdateEvent(Event _event);
        Task<IList<Event>> MyEvents(string organiser);

        Task<IList<Comment>> GetAllCommentByEventId(int eventId);

    }
}
