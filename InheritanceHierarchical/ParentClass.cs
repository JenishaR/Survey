using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHierarchical
{
    public class ParentClass
    {
        public string userName = "";
        public string ReadUserName()
        {
            Console.WriteLine("Enter your name");
            userName = Console.ReadLine();
            return userName;
        }
         public void WriteName(string value)
        {
            
            Console.WriteLine(value);
        }
        public void Type1()
        {
            Console.WriteLine("quarter");
        }
    }
}
