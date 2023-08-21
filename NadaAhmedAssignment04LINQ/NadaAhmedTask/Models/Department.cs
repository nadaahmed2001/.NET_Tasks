using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadaAhmedTask.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
