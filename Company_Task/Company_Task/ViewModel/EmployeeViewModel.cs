using Company_Task.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Company_Task.ViewModel
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
            
        }
        //public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Middle name is required.")]
        [StringLength(50, ErrorMessage = "Middle name cannot exceed 50 characters.")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }

       
        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "State is required.")]
        public string State { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }


        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }


        [Required(ErrorMessage = "PostalCode is required.")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "CreatedDate is required.")]
        [Display(Name = "CreatedDate")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }


    }
}
