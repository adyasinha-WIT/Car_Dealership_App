using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT5503_Assignment2_2230449
{
    internal class Program
    {
            static void Main(string[] args)
            {
            bool continueShopping = true;

            while (continueShopping)
            {
                Console.WriteLine("\n**********************Latest Car Dealership Business!**********************");
                Console.WriteLine("\n1. Suzuki $7000");
                Console.WriteLine("2. Hondal $8000");
                Console.WriteLine("3. Tesla $9000");
                Console.WriteLine("Please enter your choice of car");
                Console.WriteLine("Further details- GST and Total Price can be viewed based on your choice");
                Console.WriteLine("***************************************************************************");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    double price = 0;
                    switch (choice)
                    {
                        case 1:
                            price = 7000;
                            break;
                        case 2:
                            price = 8000;
                            break;
                        case 3:
                            price = 9000;
                            break;
                        default:
                            Console.WriteLine("Wrong choice. Please enter a valid choice.");
                            continue;
                    }

                    double gst = price * 0.15;
                    double total = price + gst;

                    Console.WriteLine($"The GST is: {gst}");
                    Console.WriteLine($"And the Total Price is: {total}");

                    Console.WriteLine("Do you wish to continue shopping? (Y/N)");
                    char response = char.ToUpper(Console.ReadKey().KeyChar);
                    if (response == 'N')
                    {
                        continueShopping = false;
                        Console.WriteLine("\nHave a nice day!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
                }
            }
        }
        }


}


