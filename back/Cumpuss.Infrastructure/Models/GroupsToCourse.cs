namespace Cumpuss.Infrastructure.Models
{
    public partial class GroupsToCourse
    {
        public int GroupId { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Group Group { get; set; }
    }
}
