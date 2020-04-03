using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWork1.Data
{
    public class Resume
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string WorkName { get; set; }
        [Required]
        public string WorkPlace { get; set; }
        [Required]
        public Author Author { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public DateTime WorkStart { get; set; }
        [Required]
        public DateTime WorkEnd { get; set; }
        
    }
}