using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Test
    {
        [Key]
        public int Id
        {
            get;
            set;
        }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [StringLength(15, MinimumLength = 2)]
        public string Name
        {
            get;
            set;
        }
        [StringLength(50, MinimumLength = 5)]
        public string Description
        {
            get;
            set;
        }
        [Required]
        public bool Lock
        {
            get;
            set;
        }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        public List<Question> Questions { get; set; } = new List<Question>();
    }
}
