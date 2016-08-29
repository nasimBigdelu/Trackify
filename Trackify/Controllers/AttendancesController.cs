using System.Linq;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Trackify.Models;

namespace Trackify.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend([FromBody] int eventId)
        {
            var userId = User.Identity.GetUserId();

            var exist = _context.Attendances.Any(
                a => a.AttendeeId == userId &&
                a.EventId == eventId);

            if (exist)
                return BadRequest("Attendance Already Exists");

            var attendance = new Attendance
            {
                EventId = eventId,
                AttendeeId = userId

            };

            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();
        }
    }
}
