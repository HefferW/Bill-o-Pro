namespace Bill_o_Pro.Models
{
    public enum UserPermission
    {
        DefaultUser = 0,
        Administrator = 1
    }
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<UserPermission> Permission { get; set; }
    }
}
