using System.Collections.Generic;
using Trackify.Models;

namespace Trackify.ViewModels
{
    public class EventFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}