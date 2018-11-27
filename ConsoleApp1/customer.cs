using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customer
    {
        public string name { get; set; }
        public int balance { get; set; }


        public void ShowCustomer()
        {
            Console.WriteLine(name);

        }

    }
}