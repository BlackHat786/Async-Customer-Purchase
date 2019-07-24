using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    public class Class1
    {

        async Task<double> NumItems()
        {
            int numItems = 0;
            string NameItems = "";
            double price = 0.0, discount = 0.05, total = 0.0;
            Console.Write("Enter Number of items purchased: ");
            numItems = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numItems; i++)
            {
                Console.Write("Enter the name of Item purchased: ");
                NameItems = Console.ReadLine();

                Console.Write("Enter The Price of Item: ");
                price = Convert.ToDouble(Console.ReadLine());

                total += price;

            }

            if (total > 20)
            {
                total = total - (total * discount);
            }

            await Task.Delay(1000);
            Console.Write("Total Price: R" + total);
            return total;

        }

       public void display()
        {
            string name = "", sname = "";

            Console.Write("Enter customer's name: ");
            name = Console.ReadLine();

            Console.Write("Enter the customer's Surname: ");
            sname = Console.ReadLine();
            NumItems();

        }

    }
}
