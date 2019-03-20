using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewLogBook.Entities;
using NewLogBook.Models;
using NewLogBook.Repositories.interfaces;

namespace NewLogBook.Controllers
{
    public class DepartamentController : Controller
    {
        private IDepartamentRepository departamentRepository;
        public DepartamentController(IDepartamentRepository departamentRepository)
        {
            this.departamentRepository = departamentRepository;
        }
        public async Task<IActionResult> Index()
        {
            return View(await departamentRepository.ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name")] DepartamentModel model)
        {
            if (ModelState.IsValid)
            {
                if (!await departamentRepository.CreateDepartamentPost(model))
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            DepartamentModel departament = await departamentRepository.GetEditDepartament(id);
            if (departament == null)
            {
                return NotFound();
            }

            return View(departament);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Id, Name")] DepartamentModel model)
        {
            if (ModelState.IsValid)
            {
                if (!await departamentRepository.EditDepartamentPost(model))
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        public async Task<IActionResult> Details(int? id)
        {
            Departament departament = await departamentRepository.DetailsDepartament(id);
            if (departament == null)
            {
                return NotFound();
            }

            return View(departament);
        }
    }
}