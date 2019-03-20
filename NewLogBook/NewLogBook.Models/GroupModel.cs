using Microsoft.AspNetCore.Mvc.Rendering;
using NewLogBook.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using NewLogBook.Models.interfaces;

namespace NewLogBook.Models
{
    public class GroupModel : ICloneable, IDropDownList
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Enter group name!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Choose faculty!")]
        [Display(Name = "Faculty")]
        public string FacultyId { get; set; }
        public Faculty Faculty { get; set; }

        public List<Faculty> Faculties { get; set; }

        public GroupModel()
        {
        }

        public SelectList GetSelectList()
        {
            return new SelectList(Faculties,"Id", "Name");
        }

        public object Clone()
        {
            if (this.Faculties.Count == 0)
            {
                return null;
            }
            return new GroupModel{Id =  this.Id, Name = this.Name, FacultyId = this.FacultyId,
                Faculty = this.Faculty, Faculties = this.Faculties
            };
        }

        public List<SelectListItem> GetListItemSelected()
        {
            
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (Faculty VARIABLE in Faculties)
            {
                if (Faculty.Id.Equals(VARIABLE.Id))
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
