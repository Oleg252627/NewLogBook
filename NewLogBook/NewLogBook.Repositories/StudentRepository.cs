using System;
using System.Collections.Generic;
using System.Text;
using NewLogBook.AppContext;
using NewLogBook.Entities;
using NewLogBook.Repositories.interfaces;

namespace NewLogBook.Repositories
{
    public class StudentRepository : DbRepository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
