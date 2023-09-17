﻿using BookReadingEvent.Business.Data;
using BookReadingEvent.Business.Repository.Base;
using BookReadingEvent.Foundation.Entities;
using BookReadingEvent.Foundation.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReadingEvent.Business.Repository
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        private readonly EventContext _commentContext;

        public CommentRepository(EventContext commentContext) : base(commentContext)
        {
            this._commentContext = commentContext;
        }
        public async Task<int> PostComment(Comment response)
        {
            var newComment = new Comment()
            {
                comment = response.comment,
                //timeStamp = response.timeStamp,
                EventId = response.EventId
            };
            await _commentContext.Comment.AddAsync(newComment);
            _commentContext.SaveChanges();
            return newComment.Id;
        }

        public async Task<IList<Comment>> GetComments()
        {
            return await _commentContext.Comment.OrderBy(x => x.timeStamp).ToListAsync();
        }
        public async Task<Comment> ViewComment(int commentId)
        {
            return await _commentContext.Comment.FindAsync(commentId);
        }
        public int EditComment(Comment response)
        {
            _commentContext.Comment.Update(response);
            _commentContext.SaveChanges();
            return response.Id;
        }
    }
}
