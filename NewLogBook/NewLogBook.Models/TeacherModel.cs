using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using NewLogBook.Entities;
using NewLogBook.Models.interfaces;

namespace NewLogBook.Models
{
    public class TeacherModel : ICloneable, IDropDownList
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter First name!")]
        [Display(Name = "First name")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter Last name!")]
        [Display(Name = "Last name")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Choose a department!")]
        [Display(Name = "Choose department")]
        public string DepartamentId { get; set; }
        
        public Departament Departament { get; set; }
        public List<TeacherSubject> TeacherSubjects { get; set; }
        public List<Departament> Departaments { get; set; }
        public object Clone()
        {
            if (Departaments.Count == 0)
            {
                return null;
            }
            //return new TeacherModel
            //{
            //    Id = this.Id, FirstName = this.FirstName, LastName = this.LastName,
            //    DepartamentId = this.DepartamentId, Departament = this.Departament, TeacherSubjects = this.TeacherSubjects,
            //    Departaments = this.Departaments
            //};
            return this.MemberwiseClone();
        }

        public SelectList GetSelectList()
        {
            return new SelectList(Departaments, "Id", "Name");
        }

        public List<SelectListItem> GetListItemSelected()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (Departament VARIABLE in Departaments)
            {
                if (Departament.Id.Equals(VARIABLE.Id))
                {
                    items.Add(new SelectListItem { Text = VARIABLE.Name, Value = $"{VARIABLE.Id}", Selected = true });
                }
                else
                {
                    items.Add(new SelectListItem { Text = VARIABLE.Name, Value = $"{VARIABLE.Id}", Selected = false });
                }

            }

            return items;
        }
    }
}
