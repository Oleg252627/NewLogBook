﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewLogBook.Entities;
using NewLogBook.Models;
using NewLogBook.Repositories.interfaces;

namespace NewLogBook.Controllers
{
    public class TeacherController : Controller
    {
        private ITeacherRepository teacherRepository;
        private IDepartamentRepository departamentRepository;
        public TeacherController(ITeacherRepository teacherRepository, IDepartamentRepository departamentRepository)
        {
            this.teacherRepository = teacherRepository;
            this.departamentRepository = departamentRepository;
        }
        public async Task<IActionResult> Index()
        {
            return View(await teacherRepository.GetTeacher());
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            TeacherModel model = await teacherRepository.GetCreateTeacher(departamentRepository);
            if (model == null)
            {
                return View("WarningTeacher");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName, LastName, DepartamentId")]
            TeacherModel model)
        {
            if (ModelState.IsValid)
            {
                if (!await teacherRepository.CreateTeacherPost(model))
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
            TeacherModel model = await teacherRepository.GetEditTeacher(id, departamentRepository);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Id, FirstName, LastName, DepartamentId")]
            TeacherModel model)
        {
            if (ModelState.IsValid)
            {
                if (!await teacherRepository.EditTeacherPost(model))
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        public async Task<IActionResult> Details(int? id)
        {
            Teacher teacher = await teacherRepository.DetailsTeacher(id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (!await teacherRepository.IsDeleteTeacher(id))
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}