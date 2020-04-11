using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWork1.Data
{
    public class Services
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public string Logopath { get; set; }
        
        public Author Author { get; set; }
        [Required]
        public int AuthorId { get; set; }
    }
}