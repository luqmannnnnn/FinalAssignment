using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_FinalAssignment
{
    class Policy
    {
        private int pNo;
        private string pTC;
        private string premimumType;
        private double premiumPrice;
        private DateTime startDate;
        private DateTime endDate;

        public int PNo
        {
            get
            {
                return pNo;
            }

            set
            {
                pNo = value;
            }
        }

        public string PTC
        {
            get
            {
                return pTC;
            }

            set
            {
                pTC = value;
            }
        }

        public string PremimumType
        {
            get
            {
                return premimumType;
            }

            set
            {
                premimumType = value;
            }
        }

        public double PremiumPrice
        {
            get
            {
                return premiumPrice;
            }

            set
            {
                premiumPrice = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }

        //int payOut

        public void addRider()
        {

        }
    }
}
