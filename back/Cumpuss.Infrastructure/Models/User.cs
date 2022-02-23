namespace Cumpuss.Infrastructure.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int UserType { get; set; }

        public virtual Person Person { get; set; }
    }
}
