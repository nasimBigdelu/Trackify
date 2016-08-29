using System.Collections.Generic;
using Trackify.Models;

namespace Trackify.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Event> UpcomingEvents { get; set; }
        public bool ShowActions { get; set; }
    }
}