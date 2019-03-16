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
    public class FacultyController : Controller
    {
        private readonly IFacultyRepository facultyRepository;
         public FacultyController(IFacultyRepository facultyRepository)
         {
             this.facultyRepository = facultyRepository;
         }
        public async Task<IActionResult> Index()
        {
            return View(await facultyRepository.ToListAsync());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name")]FacultyModel faculty)
        {
            if (ModelState.IsValid)
            {
               await facultyRepository.CreateFaculty(faculty);
               return RedirectToAction(nameof(Index));
            }

            return View(faculty);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            FacultyModel facultyModel = await facultyRepository.FindFaculty(id);
            if (facultyModel == null)
            {
                return NotFound();
            }

            return View(facultyModel);
        }

        public async Task<IActionResult> Edit([Bind("Name,id")] FacultyModel faculty)
        {
            if (ModelState.IsValid)
            {
                if (!await facultyRepository.EditFaculty(faculty))
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(faculty);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (!await facultyRepository.DeleteFaculty(id))
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            Faculty faculty = await facultyRepository.DetailsFaculty(id);
            if (faculty == null)
            {
                return NotFound();
            }

            return View(faculty);
        }
    }
}