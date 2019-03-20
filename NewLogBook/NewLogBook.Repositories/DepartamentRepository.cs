using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewLogBook.AppContext;
using NewLogBook.Entities;
using NewLogBook.Models;
using NewLogBook.Repositories.interfaces;

namespace NewLogBook.Repositories
{
    public class DepartamentRepository : DbRepository<Departament>, IDepartamentRepository
    {
        public DepartamentRepository(AppDbContext context) : base(context)
        {
            
        }

        public async Task<bool> CreateDepartamentPost(DepartamentModel model)
        {
            Departament departament = new Departament{Name = model.Name};
            return await AddItemAsync(departament);
        }

        public async Task<DepartamentModel> GetEditDepartament(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var departament = await GetItemAsync(id);
            if (departament == null)
            {
                return null;
            }
            return new DepartamentModel{Name = departament.Name};
        }

        public async Task<bool> EditDepartamentPost(DepartamentModel model)
        {
            var departament = await GetItemAsync(model.Id);
            departament.Name = model.Name;
            return await UpdateItem(departament);
        }

        public async Task<Departament> DetailsDepartament(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var departament = AllItems.Include(t => t.Teachers).FirstOrDefaultAsync(z => z.Id == id);
            return await departament;
        }
    }
}
