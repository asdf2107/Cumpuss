namespace Cumpuss.Infrastructure.Models
{
    public partial class Grade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public double Value { get; set; }

        public virtual Class Class { get; set; }
        public virtual Student Student { get; set; }
    }
}
