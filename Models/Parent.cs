using System.ComponentModel.DataAnnotations;

namespace Pschool.Models
{
    public class Parent
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        public string? Username { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address format")]
        public string Email { get; set; }
        public string? HomeAddress { get; set; }
        public string? Phone1 { get; set; }
        public string? WorkPhone { get; set; }
        public string? HomePhone { get; set; }
        [Required(ErrorMessage = "Siblings are required")]
        public string Siblings { get; set; }

    }
}