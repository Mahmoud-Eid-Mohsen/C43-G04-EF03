using Demo.Dbcontexts;
using Demo.Models;
using System.Text.Json;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using Dbcontext dbcontext = new Dbcontext();
            #region Mapping inhertace
            // 3 way for mapping inheertance 
            //1.TPH ->(Default) one table for base and his child
            //2. TPT -> one table for all type 
            //3. TPCC => one table for All concreate class
            //var parttime = new PartTimeEmployee() 
            //{
            //    Name="mahmoud",
            //    Adress="Fayoum",
            //    Email="me1673",
            //    HourRate=500,
            //    HourWorked=500,


            //};
            //var fulltime = new FulltimeEmployee()
            //{

            //    Name = "Ahmed",
            //    Adress = "Fayoum",
            //    Email = "Eidm11",
            //    MonthlySalary=25000

            //};
            //dbcontext.Employees.AddRange(parttime, fulltime);
            //dbcontext.SaveChanges();


            #endregion
            #region Data seeding
            /*
             json
            "Id":10,
            "Name":"mahmoud"
             
             */


            //var Data = File.ReadAllText("path");
            //var emplpyees= JsonSerializer.Deserialize<IEnumerable<Employee>>(Data);
            //dbcontext.Employees.AddRange(emplpyees);
            //dbcontext.SaveChanges();

            #endregion
            #region insert Data with Relations
            //var Dept1 = new Department() { Name="HR"};
            //var Dept2 = new Department() { Name = "IT" };
            //var Dept3 = new Department() { Name = "Development" };


            //var Emp1 = new Employee() 
            //{

            //    Name = "Ahmed",
            //    Adress = "Alex",
            //    Email = "Eidm11"
             

            //};
            //var Emp2 = new Employee()
            //{

            //    Name = "Mahmoud",
            //    Adress = "Fayoum",
            //    Email = "me16"


            //};
            //var Emp3 = new Employee()
            //{

            //    Name = "Ali",
            //    Adress = "Cairo",
            //    Email = "mn@gmail.com"


            //};
           

            //Dept1.Employees.Add(Emp1);
            //dbcontext.Departments.Add(Dept1);


            //dbcontext.SaveChanges();




            #endregion
        }
    }
}
