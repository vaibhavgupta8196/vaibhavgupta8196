using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerModel
{
    class Dept
    {
        public int DeptNo { get; set; }
        public string Dname { get; set; }
        public string Loc { get; set; }

        public Dept()
        {
        }
        public Dept(int deptNo, string dName, string Loc)
        {
            this.DeptNo = deptNo;
            this.Dname = dName;
            this.Loc = Loc;
        }
    }
}
