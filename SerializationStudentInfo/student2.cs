using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationStudentInfo
{
    [Serializable]

    public class student2
    {
        public int stuid { get; set; }
        public string stuname { get; set; }
        public int RegestrationNo { get; set; }
        public int FinalYearPer { get; set; }
    }
}
