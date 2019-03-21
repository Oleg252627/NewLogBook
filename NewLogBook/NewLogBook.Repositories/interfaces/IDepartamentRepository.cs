using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NewLogBook.Abstracrions;
using NewLogBook.Entities;
using NewLogBook.Models;

namespace NewLogBook.Repositories.interfaces
{
    public interface IDepartamentRepository : IDbRepository<Departament>
    {
        Task<bool> CreateDepartamentPost(DepartamentModel model);
        Task<DepartamentModel> GetEditDepartament(int? id);
        Task<bool> EditDepartamentPost(DepartamentModel model);
        Task<Departament> DetailsDepartament(int? id);
        Task<bool> IsDeleteDepartament(int? id);
    }
}
