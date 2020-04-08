using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerModel
{
    [Serializable]
    public class Dept
    {
        private int deptNo;
        private string dName;
        private string loc;

        public int DeptNo { get => deptNo; set => deptNo = value; }
        public string DName { get => dName; set => dName = value; }
        public string Loc { get => loc; set => loc = value; }

        public Dept()
        { 
        }
        public Dept(int deptNo, string dName,  string loc)
        {
            this.DeptNo = deptNo;
            this.DName = dName;
            this.Loc = loc;
        }
    }
}
