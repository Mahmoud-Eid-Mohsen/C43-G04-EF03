
namespace Demo.Models
{
    public  class Employee
    {
        public string Name { get; set; } = string.Empty;
        public int EmployeeId { get; set; }
        public string Email { get; set; }= string.Empty;
        public string Adress { get; set; } = string.Empty;
        public Department Department { get; set; }  
        public int? DepartmentTd {  get; set; }
    }
}
