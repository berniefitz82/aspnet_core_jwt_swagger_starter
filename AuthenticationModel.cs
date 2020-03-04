using System.ComponentModel.DataAnnotations;

namespace Aspnet_Core_Jwt_Swagger_Starter {
    public class AuthenticationModel
    {
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
    }

}