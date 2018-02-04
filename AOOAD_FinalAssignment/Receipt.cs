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
        private string clientName;

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

        public string ClientName
        {
            get
            {
                return clientName;
            }

            set
            {
                clientName = value;
            }
        }

        public Receipt(DateTime date, string clientN ,string payItem, double payAmt)
        {
            rDAte = date;
            clientName = clientN;
            paymentItem = payItem;
            paymentAmt = payAmt;
        }
    }
}
