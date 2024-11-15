using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public  class Department
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        #region  relation between department and student 

        [InverseProperty(nameof(Student.Department))]
        public virtual ICollection<Student>? Students { get; set; }
        #endregion
        #region relation between department and subject 
[InverseProperty(nameof(DepartmentSubject.Department))]
        public virtual ICollection<Subject>? Subjects { get; set; }
        #endregion
    }
}
