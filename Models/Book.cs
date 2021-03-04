using System;
using System.ComponentModel.DataAnnotations;

namespace MoodyAssignment5.Models
{
    public class Book
    {
        //declare vars
        [Key]
        public int BookID { get; set; }

        [Required]
        public string Title { get; set; }

        public string AuthorFirst { get; set; }

        public string AuthorMiddle { get; set; }

        [Required]
        public string AuthorLast { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        [RegularExpression(@"\d{3}?-? *\d{10}")]
        public string ISBN { get; set; }

        [Required]
        public string Class { get; set; }

        [Required]
        public string Cat { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Pages { get; set; }
    }
}
