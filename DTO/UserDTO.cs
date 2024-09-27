namespace AccesoriosApp.DTO
{
    public class UserDTO
    {
        public string login { get; set; } = null!;
        public string clave { get; set; } = null!;
    }

    public class LoginResponse
    {
        public string token { get; set; } = null!;
    }
}
