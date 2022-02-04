namespace Cumpuss.Infrastructure.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public int FaceId { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public short UserType { get; set; }

        public virtual Person Face { get; set; }
    }
}
