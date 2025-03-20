namespace ExploreSV.BusinessLogic.DTOs
{
    internal class UserDto
    {
        public string UserName { get; set; } = string.Empty;
        public string UserPassword { get; set; } = string.Empty;
    }

    public class CreateUserRequest
    {
        public string UserName { get; set; } = null!;
    }

    public class UserResponse
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;

    }
}

