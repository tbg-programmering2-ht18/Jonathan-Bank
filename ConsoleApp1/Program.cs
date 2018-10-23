using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        public static List<Customer> customerbalance = new List<Customer>();


        static void Main(string[] args)
        {
            int answer = 0;


            Console.WriteLine("Wäcom to Bänk");

            Console.WriteLine("");
            while (answer != 4) //If the answer isn't for the code wil perpetually loop, if, however the answer is 4 the code will terminate.
            {
                Console.WriteLine("1 : Add customer");
                Console.WriteLine("2 : Deleeeeet");
                Console.WriteLine("3 : Show all Bois");
                Console.WriteLine("4 : leave");
                Console.WriteLine("");
                answer = Console.ReadLine();
                try
                {
                    answer = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("ERROR" + e.Message);
                    Console.ReadKey();
                    answer = 0;
                    Console.Clear()
                }

                switch (answer)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Add customer");
                        addCustomer();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        ShowAllCustomer();
                        int delet = 1;
                        delet = Convert.ToInt32(Console.ReadLine());
                        int count = 1;
                        customerbalance.RemoveAt(delet);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        foreach (var customer in customerbalance)
                        {
                            Console.WriteLine("User: {0}", customer.name);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                      






                }


            }




            Console.ReadKey();

        }

        private static void ShowAllCustomer()
        {
            foreach (var customer in customerbalance)
            {
                customer.showCustomer();
            }
        }

        public static void addCustomer()
        {
            Console.WriteLine("");
            Console.Write("Name of customer: ");
            string name = Console.ReadLine();
            Customer customer = new Customer();
            customer.name = name;
            customerbalance.Add(customer);


        }






    }
}
