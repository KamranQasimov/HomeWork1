using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWork1.Data
{
    public class Skill
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public byte Percent { get; set; }
        
        public Author Author { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        
       
    }
}