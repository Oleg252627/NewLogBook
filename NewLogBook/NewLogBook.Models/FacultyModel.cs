using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewLogBook.Models
{
    public class FacultyModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Fill in the Name field")]
        [Display(Name = "Faculty")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
    }
}
