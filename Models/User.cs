namespace MaranntaApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public DateOnly? BirthDate { get; set; }
        public string? Phone { get; set; }
    }
}