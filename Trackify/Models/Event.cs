using System;
using System.ComponentModel.DataAnnotations;

namespace Trackify.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Company { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public String Venue { get; set; }

        [Required]
        public Category Category { get; set; }
    }


}