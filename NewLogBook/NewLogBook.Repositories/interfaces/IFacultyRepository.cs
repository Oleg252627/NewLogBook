using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NewLogBook.Abstracrions;
using NewLogBook.Entities;
using NewLogBook.Models;

namespace NewLogBook.Repositories.interfaces
{
    public interface IFacultyRepository : IDbRepository<Faculty>
    {
        Task<bool> CreateFaculty(FacultyModel faculty);
        Task<FacultyModel> FindFaculty(int? id);
        Task<bool> EditFaculty(FacultyModel faculty);
        Task<bool> DeleteFaculty(int? id);
        Task<Faculty> DetailsFaculty(int? id);
    }
}
