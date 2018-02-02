using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_FinalAssignment
{
    class Client: Observer
    {
        //For Observer pattern
        private Subject policy;

        private int cAccNo;
        private string cName;
        private string cAddress;
        private string policyType;
        private string paymentMode;

        public int CAccNo
        {
            get
            {
                return cAccNo;
            }

            set
            {
                cAccNo = value;
            }
        }
        public string CName
        {
            get
            {
                return cName;
            }

            set
            {
                cName = value;
            }
        }
        public string CAddress
        {
            get
            {
                return cAddress;
            }

            set
            {
                cAddress = value;
            }
        }
        public string PolicyType
        {
            get
            {
                return policyType;
            }

            set
            {
                policyType = value;
            }
        }
        public string PaymentMode
        {
            get
            {
                return paymentMode;
            }

            set
            {
                paymentMode = value;
            }
        }

        public Client() { }
        public Client(int can,string cn,string ca)
        {
            CAccNo = can;
            CName = cn;
            CAddress = ca;
        }
        
        //For Observer Pattern
        public Client (Subject p)
        {
            this.policy = p;
            policy.registerObserver(this);
        }

        public void update(string policy)
        {

        }
    }

}
