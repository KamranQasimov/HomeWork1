using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWork1.Data
{
    public class Project
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string ImagePath { get; set; }
        [Required]
        public Author Author { get; set; }
        [Required]
        public int AuthorId { get; set; }
        

    }
}