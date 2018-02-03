using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_FinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Client> clientList = new List<Client>();
            List<Policy> policyList = new List<Policy>();
            List<Policy> newPolicyList = new List<Policy>();
            List<Receipt> receiptList = new List<Receipt>();
            

            clientList.Add(new Client(001, "Tan Kah Kee", "15 Bedok North Road Singapore: 130355"));
            clientList.Add(new Client(002, "Ahmad Ibrahim", "BLK 33 Tech Whye Lane Singapore: 4020333"));
            clientList.Add(new Client(003, "Saravanan T.", "BLK 21 Jalan Bukit Merah Singapore: 521421"));

            policyList.Add(new Travel());
            policyList.Add(new Medical());
            policyList.Add(new Car());

           

            while (true)
            {
                //Display Choice Menu
                DisplayMenu();
                Console.Write("Enter Your Option: ");
                int userOption = Convert.ToInt32(Console.ReadLine());

                if (userOption == 1)
                {
                    //Display available policies
                    Console.WriteLine("\n- Available Policies: ");
                    for (int i = 0; i < policyList.Count; i++)
                    {
                        Console.WriteLine("{0}. {1}",i+1, policyList[i].PName);
                    }
                    Console.Write("\nSelect Policy: ");
                    int policyIndex = Convert.ToInt32(Console.ReadLine())-1;

                    //Display existing clients
                    Console.WriteLine("\n- Existing Clients: ");
                    Console.WriteLine("{0,-5} {1,-20} {2,-30}", "ID:", "Name:", "Address");
                    for (int i = 0; i < clientList.Count; i++)
                    {                 
                        Console.WriteLine("{0,-5} {1,-20} {2,-30}", clientList[i].CAccNo, clientList[i].CName, clientList[i].CAddress);
                    }
                    Console.Write("\nSelect Existing Client: ");
                    int clientIndex = Convert.ToInt32(Console.ReadLine())-1;

                    //Enter Start date:
                    Console.Write("\nEnter Start Date(MM/dd/yyyy): ");
                    DateTime startDate = DateTime.Parse(Console.ReadLine());


                    //Enter end date:
                    Console.Write("\nEnter End Date(MM/dd/yyyy): ");
                    DateTime endDate = DateTime.Parse(Console.ReadLine());

                    int nplIndex = newPolicyList.Count;
                    newPolicyList.Add(new Policy(nplIndex, policyList[policyIndex].PName, clientList[clientIndex].CName, startDate, endDate, policyList[policyIndex].PremiumPrice));
                    Console.WriteLine("\nSummary:\n{0,-5} {1,-20} {2,-20} {3,-20} {4,-20}", nplIndex, policyList[policyIndex].PName, clientList[clientIndex].CName, startDate.ToString("dd/MM/yyyy"), endDate.ToString("dd/MM/yyyy"), policyList[policyIndex].PremiumPrice);

                    Console.WriteLine("\t-----");
                    for (int i = 0; i < newPolicyList.Count; i++)
                    {
                        Console.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-20}, {5,-20}", newPolicyList[i].PNo, newPolicyList[i].PName, newPolicyList[i].CName, newPolicyList[i].StartDate.ToString("dd/MM/yyyy"), newPolicyList[i].EndDate.ToString("dd/MM/yyyy"), newPolicyList[i].PremiumPrice);
                            
                          
                    }

                }

                else if (userOption == 2)
                {
               
                }

                else if (userOption == 3)
                {
                    
                }

                else if (userOption == 4)
                {
                    DisplayOutstandingPayments(clientList);
                }

                else if (userOption == 0)
                {
                    Console.WriteLine("Exiting the program");
                    break;
                }

            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("------------- Welcome to Provident Life--------------");
            Console.WriteLine("1. Create Insurance Policy");
            Console.WriteLine("2. Edit Existing Policy");
            Console.WriteLine("3. Send an Email Alert");
            Console.WriteLine("4. View Outstanding Insurance Preimums");
            Console.WriteLine("0. Exit the Program");
            Console.WriteLine("-----------------------------------------------------");
        }

        static void DisplayOutstandingPayments(List<Client> clientList, List<Receipt> receiptList)
        {
            //View Oustanding Insurance Premiums
            Console.WriteLine("-------------View Outstanding Insurance Premiums------------");
            Console.WriteLine("Enter Account Number:");
            int userAccNo = Convert.ToInt32(Console.ReadLine());

            //Display Client Details
            for (int i = 0; i < clientList.Count; i++)
            {
                if (userAccNo == clientList[i].CAccNo)
                {
                    Console.WriteLine("{0,-5} {1,-20} {2,-30}", "ID:", "Name:", "Address");
                    Console.WriteLine("{0,-5} {1,-20} {2,-30}", clientList[i].CAccNo, clientList[i].CName, clientList[i].CAddress);
                }
            }

            //Promopt Insurance End-Date
            Console.WriteLine("Please Enter Insurance End-Date (DD/MM/YYYY): ");
            DateTime insuranceEndDate = Convert.ToDateTime(Console.ReadLine());

            //System Checks if the Payment is Overdue
            if (DateTime.Now > insuranceEndDate)
            {
                Console.WriteLine("You have an Oustanding Payment. Please pay using a Credit Card");

                Console.WriteLine("Enter Full Name on Credit Card: ");
                string userCreditName = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter Credit Card Number: ");
                string userCreditNo = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter Expiry Date: ");
                string userCreditExpiry = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter Security Code: ");
                string userCreditCode = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter Pin: ");
                string userCreditPin = Convert.ToString(Console.ReadLine());

                


            }

            else
            {
                Console.WriteLine("You have no Outstanding Payments. Thank You");
            }
      
          
        }
    }
}
