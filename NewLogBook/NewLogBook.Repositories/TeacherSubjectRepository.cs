using System;
using System.Collections.Generic;
using System.Text;
using NewLogBook.AppContext;
using NewLogBook.Entities;
using NewLogBook.Repositories.interfaces;

namespace NewLogBook.Repositories
{
    public class TeacherSubjectRepository : DbRepository<TeacherSubject>, ITeacherSubjectRepository
    {
        public TeacherSubjectRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
