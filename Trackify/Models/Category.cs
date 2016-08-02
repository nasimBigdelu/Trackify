using System;
using System.ComponentModel.DataAnnotations;

namespace Trackify.Models
{
    public class Category
    {

        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }
    }
}
