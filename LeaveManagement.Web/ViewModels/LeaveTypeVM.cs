using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.ViewModels
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        
        [Display (Name = "Leave Type")]
        [Required]
        public string Name { get; set; }
        
        [Display(Name = "Default Number Of Days")]
        [Required]
        [Range(1, 25, ErrorMessage = "Please Enter Between 1 and 25")]
        public int DefaultDays { get; set; }
    }
}


