using AutoMapper;
using BookReadingEvent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReadingEvent.Services
{
    public class IndexPageService : IIndexPageService
    {
        private readonly IMapper _mapper;
        public IndexPageService(IMapper mapper)
        {
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
    }
}
