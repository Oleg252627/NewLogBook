using System;
using System.Collections.Generic;
using System.Text;
using NewLogBook.AppContext;
using NewLogBook.Entities;
using NewLogBook.Repositories.interfaces;

namespace NewLogBook.Repositories
{
    public class TeacherRepository : DbRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
