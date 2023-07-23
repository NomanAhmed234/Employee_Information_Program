using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6q4
{
    internal class Employee
    {
        public string name, dept, design;
        public void EmpName()
        {
            Console.WriteLine("Give your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Register Employee's Name: {0}\n", name);
        }
        public void DeptList()
        {
            Console.WriteLine("Give your Department: ");
            dept = Console.ReadLine();
            Console.WriteLine("Employee's Department: {0}\n",dept);
        }
        
        public void EmpDesign()
        {
            Console.WriteLine("Give your Designation: ");
            design = Console.ReadLine();
            Console.WriteLine("Employee's current Designation: {0}\n", design);
        }


    }
}
