namespace Mango.Services.AuthAPI.Models.Dto
{
    public class LoginResposeDto
    {
        public UserDto User{ get; set; }
        public string Token{ get; set; }
    }
}
