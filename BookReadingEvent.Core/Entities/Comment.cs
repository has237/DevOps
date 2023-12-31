﻿using BookReadingEvent.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReadingEvent.Core.Entities
{
    public class Comment : Entity
    {
        [ForeignKey("Event")]
        public int EventId { get; set; }

        [Required(ErrorMessage = "Please write a comment before posting")]
        public string comment { get; set; }

        public DateTime timeStamp { get; set; }

        public Event _Event { get; set; }

        public Comment()
        {
            timeStamp = DateTime.Now;
        }
    }
}
