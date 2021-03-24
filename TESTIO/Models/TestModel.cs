using System;
using System.ComponentModel.DataAnnotations;

namespace TESTIO.Models
{
    public class TestModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool Lock { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
