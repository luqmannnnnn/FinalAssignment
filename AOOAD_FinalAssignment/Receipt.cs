using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_FinalAssignment
{
    class Receipt
    {
        private int myreceipt;
        private DateTime rDAte;
        private string paymentItem;
        private double paymentAmt;

        public int MyReceipt
        {
            get
            {
                return myreceipt;
            }

            set
            {
                myreceipt = value;
            }
        }

        public DateTime RDAte
        {
            get
            {
                return rDAte;
            }

            set
            {
                rDAte = value;
            }
        }

        public string PaymentItem
        {
            get
            {
                return paymentItem;
            }

            set
            {
                paymentItem = value;
            }
        }

        public double PaymentAmt
        {
            get
            {
                return paymentAmt;
            }

            set
            {
                paymentAmt = value;
            }
        }
    }
}
