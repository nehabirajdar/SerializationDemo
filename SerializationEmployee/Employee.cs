using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    [Serializable]
   public class Employee
    {
        public int empid { get; set; }
        public string empname { get; set; }    
        public string city { get; set; }
        public string Salary { get; set; }

    }
}
