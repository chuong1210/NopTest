using System.ComponentModel.DataAnnotations;

namespace AppWeb.Request
{
    public class UpdateUserRequest
    {
        public string Name { get; set; } = string.Empty;
        [StringLength(500)]
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }

        public int Gender { get; set; } = 0;

        public string Password { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
