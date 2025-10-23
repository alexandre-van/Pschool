using System.ComponentModel.DataAnnotations;

namespace Pschool.Models
{
    public class Students
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string? Username { get; set; }
        public string Email { get; set; }
        [Required]
        public string? HomeAddress { get; set; }
        public string? Phone1 { get; set; }
        public string? WorkPhone { get; set; }
        public string? HomePhone { get; set; }
        public string? Siblings { get; set; }
        [Required]
    }
}