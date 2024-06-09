using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Company_Task.Models
{
    public class Employee
    {
         public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MobileNO { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Addresss { get; set; }
        //public string PostalCode { get; set; }
        //public string Location { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        
    }
}
