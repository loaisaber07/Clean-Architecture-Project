using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class DepartmentSubject
    {
        public int DepartmentId { get; set; } 
        public virtual Department? Department { get; set; } 
        public int SubjectId { get; set; }
        public virtual Subject? Subject { get; set; }   
    }
}
