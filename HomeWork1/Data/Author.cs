using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Description;


namespace HomeWork1.Data
{
    public class Author
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int CompletedProjects { get; set; }
        [Required]
        public int CupsOfCoffee { get; set; }
        [Required]
        public int AwardsAmount { get; set; }
        [Required]
        public string Work { get; set; }
        [Required]
        public ICollection<Services> Services { get; set; }
        [Required]
        public ICollection<Skill> Skills { get; set; }
        [Required]
        public ICollection<Project> Projects { get; set; }


    }
}