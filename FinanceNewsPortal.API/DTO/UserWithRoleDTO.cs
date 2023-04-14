using System.ComponentModel;

namespace FinanceNewsPortal.API.DTO
{
    public class UserWithRoleDTO
    {
        public string Id { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Email Address")]
        public string Email { get; set; }

        public char Gender { get; set; }

        public string? ImageFilePath { get; set; }

        public bool Status { get; set; }

        public string Role { get; set; }
    }
}