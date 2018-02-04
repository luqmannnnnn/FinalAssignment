using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_FinalAssignment
{
    class Rider
    {
        private string riderName;
        private string riderDesc;
        private int rPremiumPrice;

        public string RiderName
        {
            get
            {
                return riderName;
            }

            set
            {
                riderName = value;
            }
        }

        public string RiderDesc
        {
            get
            {
                return riderDesc;
            }

            set
            {
                riderDesc = value;
            }
        }

        public int RPremiumPrice
        {
            get
            {
                return rPremiumPrice;
            }

            set
            {
                rPremiumPrice = value;
            }
        }

        public Rider(string name, string desc, int price)
        {
            riderName = name;
            riderDesc = desc;
            rPremiumPrice = price;
        }
    }
}
