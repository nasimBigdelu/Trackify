using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trackify.Models
{
    public class Following
    {
        // This class uses a combination of FollowerId and FolloweeId as key

        [Key]
        [Column(Order = 1)]
        public string FollowerId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string FolloweeId { get; set; }

        public ApplicationUser Follower { get; set; }
        public ApplicationUser Followee { get; set; }
    }
}