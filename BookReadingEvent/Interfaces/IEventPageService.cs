﻿using BookReadingEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReadingEvent.Interfaces
{
    public interface IEventPageService
    {
        Task<IList<EventViewModel>> GetEvents();
        Task<EventViewModel> ViewDetails(int eventId);

        Task<int> CreateEvent(EventViewModel eventViewModel);

        int UpdateEvent(EventViewModel eventViewModel);

        Task<IList<EventViewModel>> MyEvents(string organiser);
        Task<IList<CommentViewModel>> GetAllCommentByEventId(int eventId);
    }
}
