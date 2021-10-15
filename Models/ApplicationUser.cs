using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KetoBlog.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int Id { get; set; }

        public string UserEmail { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime SignUpDateTime { get; set; }
    }
}
