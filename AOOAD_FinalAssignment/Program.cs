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
            //Display Choice Menu
            DisplayMenu();

            while (true)
            {
                Console.WriteLine("Enter Your Option: ");
                int userOption = Convert.ToInt32(Console.ReadLine());

                if (userOption == 1)
                {
                    
                }

                else if (userOption == 2)
                {
               
                }

                else if (userOption == 3)
                {
                    
                }

                else if (userOption == 4)
                {
                    
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
            Console.WriteLine("2. Edit Exisiting Policy");
            Console.WriteLine("3. Send an Email Alert");
            Console.WriteLine("4. View Outstanding Insurance Preimums");
            Console.WriteLine("0. Exit the Program");
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
