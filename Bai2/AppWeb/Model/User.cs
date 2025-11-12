using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;

namespace AppWeb.Model
{

    public class User
    {
        public int Id { get; set; }
        [Required][StringLength(100)]
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
