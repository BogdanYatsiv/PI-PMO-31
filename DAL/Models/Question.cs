using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Question
    {
        [Key]
        public int Id
        {
            get;
            set;
        }
        [ForeignKey("Test")]
        public int TestId { get; set; }

        [Required]
        public string Description
        {
            get;
            set;
        }

        public List<Answer> Answers { get; set; } = new List<Answer>();
    }
}
