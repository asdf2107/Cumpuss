using System.Collections.Generic;

namespace Cumpuss.Infrastructure.Models
{
    public partial class Person
    {
        public Person()
        {
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Sirname { get; set; }
        public string Patronymic { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
