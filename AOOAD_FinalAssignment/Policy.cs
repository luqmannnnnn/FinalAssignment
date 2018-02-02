using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_FinalAssignment
{
    public interface PayOutMethod
    {
        void pay();
    }
    public class Injury : PayOutMethod
    {
        public void pay()
        {
            Console.WriteLine("Paid");
        }
    }
    public class Maturity : PayOutMethod
    {
        public void pay()
        {
            Console.WriteLine("Paid");
        }
    }
    class Policy : Subject
    {
        //For observer pattern
        private List<Observer> observers;

        protected PayOutMethod payOutMethod;
        private string pName;
        private int pNo;
        private string pTC;
        private string premimumType;
        private double premiumPrice;
        private string cName;
        private DateTime startDate;
        private DateTime endDate;

        public void performPayOutMethod()
        {
            payOutMethod.pay();
        }
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
        public string PName
        {
            get
            {
                return pName;
            }

            set
            {
                pName = value;
            }
        }

        public string CName
        {
            get
            {
                return c.CName;
            }

            set
            {
                c.CName = value;
            }
        }

        Client c = new Client();

        public Policy(int pno, string pname, string cname, DateTime sd, DateTime ed)
        {
            PNo = pno;
            PName = pname;
            CName = cname;
            StartDate = sd;
            EndDate = ed;
        }
        //For Observer Pattern
        public Policy(){
            observers = new List<Observer>();       

        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver (Observer o)
        {
            //observers.Remove(i);
        }

        public void notifyObservers()
        {
            foreach (Observer o in observers)
            {
              //  o.update(policy);
            }
        }

        public void payOutstandingPayments()
        {
            notifyObservers();
        }

        //int payOut

        public void addRider()
        {
            //Add riders
        }
    }

    class newPolicy : Policy
    {
       
    }

    class Medical : Policy
    {
        public Medical()
        {
            PNo = 0;

            PName = "Medical Insurance";
            PTC = "This insurance covers only one traveller and in not refunadable";
            PremimumType = "Periodic Payment: Monthly";
            PremiumPrice = 134;
            payOutMethod = new Injury();
        }
    }
    class Car: Policy
    {
        public Car() {
            PNo = 0;
            PName = "Car Insurance";
            PTC = "This insurance covers only one car and in not refunadable";
            PremimumType = "Periodic Payment: Yearly";
            PremiumPrice = 1470;
            payOutMethod = new Maturity();
        }
    }
    class Travel: Policy
    {
      
        public Travel() {
            PNo = 0;
            PName = "Travel Insurance";
            PTC = "This insurance covers only one traveller and is not refunadable";
            PremimumType = "One Time Payment";
            PremiumPrice = 57.90;
            payOutMethod = new Maturity();
        }
    }
    
}
