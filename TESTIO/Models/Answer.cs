using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TESTIO.Models
{
    public class Answer
    {
        [Key]
        public int Id
        {
            get;
            set;
        }
        [Required]
        public string Description
        {
            get;
            set;
        }
        [Required]
        public bool IsTrue { get; set; }

        [ForeignKey("Question")]
        public int QuestionId
        {
            get;
            set;
        }
    }
}
