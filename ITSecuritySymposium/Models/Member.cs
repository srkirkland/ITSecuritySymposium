namespace ITSecuritySymposium.Models
{
    public class Member : DomainObject
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
    }
}