using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace PoorManDinerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var summerMenu = new FoodMenu(){Name = "Summer menu"};
           
            summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Salmon with Butter", 13.99);
            summerMenu.AddMenuItem("Butter Chicken", " Braised Roased Chicken in butter and garlic suace", 12.99);
            summerMenu.HospitalDirections = "Take a left on hospital way on right .2 miles";

            var drinkMenu = new DrinksMenu();
            drinkMenu.Disclaimer = " Do not drink to fast!";

            drinkMenu.AddMenuItem("Virgin Cuba Libre", " A classic", 4.50);
            drinkMenu.AddMenuItem("Coca-Cola Rootbeer" , "Heavy and delicious", 6.50);
            drinkMenu.AddMenuItem("Long Island IceTea", " Sweet, Sour and Strong", 9.00);

            var hungryCustomer = new Order();

           
            foreach (MenuItem currMenuItem in drinkMenu.Items)
            {
                hungryCustomer.Items.Add(currMenuItem);
               
            }
            foreach (MenuItem currentMenuItem in summerMenu.Items)
            {
                hungryCustomer.Items.Add(currentMenuItem);
            }
            Console.WriteLine("Your total is {0} ", hungryCustomer.Total);
            try
            {
                drinkMenu.AddMenuItem("Pina Colada", "Very Sweet", -.32);
            }
            catch(Exception thrownException)
            {
                Console.WriteLine(thrownException.Message);
            }
            Console.ReadLine();
        }
    }
}
