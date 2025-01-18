using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    internal class UserRole
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
