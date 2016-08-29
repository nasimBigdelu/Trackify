﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trackify.Models
{
    public class Attendance
    {
        public Event Event { get; set; }
        public ApplicationUser Attendee { get; set; }

        [Key]
        [Column(Order = 1)]
        public int EventId { get; set; }

        [Key]
        [Column(Order = 2)]
        public String AttendeeId { get; set; }

    }
}