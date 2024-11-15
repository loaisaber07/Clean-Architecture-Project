using Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataBase
{
    public class SchoolDataBase :DbContext
    { 
       public DbSet<Department> Departments { get; set; }
      public  DbSet<Subject> Subjects { get; set; }
       public DbSet<DepartmentSubject> DepartmentSubjects { get; set; }
        public DbSet<Student> Students { get; set; }
       public  DbSet<StudentSubject> StudentSubjects { get; set; }

        public SchoolDataBase(DbContextOptions<SchoolDataBase> options) : base(options)
        {
        }
    }
}
