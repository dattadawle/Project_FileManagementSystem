using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }

        //  [ForeignKey("User")]
        public int UserId { get; set; }

        // [ForeignKey("Role")]
        public int RoleId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}
