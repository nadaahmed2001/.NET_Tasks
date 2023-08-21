using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadaAhmedTask.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("StudDept")]
        public int DepartmentID {get; set; }
        public virtual Department StudDept { get; set; }
    }
}
