using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_FinalAssignment
{
    class Employee
    {
        private string staffName;
        private int staffNo;
        private int policiesSold;

        public string StaffName
        {
            get
            {
                return staffName;
            }

            set
            {
                staffName = value;
            }
        }

        public int StaffNo
        {
            get
            {
                return staffNo;
            }

            set
            {
                staffNo = value;
            }
        }

        public int PoliciesSold
        {
            get
            {
                return policiesSold;
            }

            set
            {
                policiesSold = value;
            }
        }

        public double totalComm()
        {
            return 0;
        }
    }
}
