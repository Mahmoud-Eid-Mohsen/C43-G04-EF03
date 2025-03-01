using Demo.Dbcontexts;
using Demo.Models;

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
            var parttime = new PartTimeEmployee() 
            {
                Name="mahmoud",
                Adress="Fayoum",
                Email="me1673",
                HourRate=500,
                HourWorked=500,
            
            
            };
            var fulltime = new FulltimeEmployee()
            {

                Name = "Ahmed",
                Adress = "Fayoum",
                Email = "Eidm11",
                MonthlySalary=25000

            };
            dbcontext.Employees.AddRange(parttime, fulltime);
            dbcontext.SaveChanges();


            #endregion


        }
    }
}
