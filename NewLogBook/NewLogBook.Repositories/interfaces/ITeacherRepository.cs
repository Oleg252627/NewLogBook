using System;
using System.Collections.Generic;
using System.Text;
using NewLogBook.Abstracrions;
using NewLogBook.Entities;

namespace NewLogBook.Repositories.interfaces
{
    public interface ITeacherRepository : IDbRepository<Teacher>
    {
    }
}
