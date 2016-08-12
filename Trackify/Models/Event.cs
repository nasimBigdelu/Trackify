using System;
using System.ComponentModel.DataAnnotations;

namespace Trackify.Models
{
    public class Event
    {
        public int Id { get; set; }

        public ApplicationUser Company { get; set; }

        [Required]
        public string CompanyId { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public String Venue { get; set; }

        public Category Category { get; set; }

        [Required]
        public byte CategoryId { get; set; }
    }


}