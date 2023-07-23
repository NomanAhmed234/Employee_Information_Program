/*Write a C# code which created a public class Employee with its public member variables name ,
dept and design. Now create method EmpName( ) which takes user input for employee name
and then pint the name also. Create another method DeptList( ) that takes input the name of
department of employee and third method as EmpDesign( ) which just takes input about
employee’s designation. In main call these methods and print appropriate results.*/

namespace Lab_6q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.EmpName();
            emp1.DeptList();
            emp1.EmpDesign();
        }
    }
}