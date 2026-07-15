using System;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolioProject.Models
{
    public class ContactMessage
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your question")]
        [StringLength(1000)]
        public string Question { get; set; }

        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
    }
}