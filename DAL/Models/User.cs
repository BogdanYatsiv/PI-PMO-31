using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        [Key]
        public int Id
        {
            get;
            set;
        }
        [StringLength(15, MinimumLength = 2)]
        public string Name
        {
            get;
            set;
        }
        [StringLength(15, MinimumLength = 2)]
        public string Surname
        {
            get;
            set;
        }

        public bool isAdmin
        {
            get;
            set;
        }
        [Required]
        public string Email
        {
            get;
            set;
        }
        [StringLength(22, MinimumLength = 6)]
        public string Password
        {
            get;
            set;
        }

        public List<Test> Tests { get; set; } = new List<Test>();
    }
}
