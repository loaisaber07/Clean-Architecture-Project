using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        #region Relations Between student and department  

        public int DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        public virtual Department? Department { get; set; }
        #endregion
        #region relation between student and subject
        [InverseProperty(nameof(StudentSubject.Student))]
        public virtual ICollection<Subject>? Subjects { get; set; }
        #endregion

    }
}
