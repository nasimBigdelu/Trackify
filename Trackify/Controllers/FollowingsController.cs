using System.Linq;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Trackify.Dtos;
using Trackify.Models;

namespace Trackify.Controllers
{
    [Authorize]
    public class FollowingsController : ApiController
    {

        private ApplicationDbContext _context;

        public FollowingsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto dto)
        {
            var userId = User.Identity.GetUserId();

            var exist = _context.Followings.Any(
                f => f.FolloweeId == userId &&
                f.FolloweeId == dto.FolloweeId);

            if (exist)
                return BadRequest("Following Already Exists");

            var following = new Following
            {
                FolloweeId = dto.FolloweeId,
                FollowerId = userId

            };

            _context.Followings.Add(following);
            _context.SaveChanges();

            return Ok();
        }
    }
}
