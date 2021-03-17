using System;
using System.ComponentModel.DataAnnotations;

namespace API_AJAX_Mvc.Models
{
    public class DeptHeadCount
    {
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public int Position { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public string Office { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public int? Salary { get; set; }

        public string ImagePath { get; set; }
    }
}
