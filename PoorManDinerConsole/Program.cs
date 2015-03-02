using System;
using System.Collections.Generic;
using PoorManDiner.Business;

namespace PoorManDinerConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Menu> menusFromDatabase = Menu.GetAllMenus();
            Menu firstMenu = menusFromDatabase[0];
            firstMenu.SaveNewMenuItem("Smorgas", "A classic nordic dish.", 10.99);
            menusFromDatabase = Menu.GetAllMenus();

            var hungryCustomer = new Order();

            foreach (Menu currentMenu in menusFromDatabase)
            {
                foreach (MenuItem currentMenuItem in currentMenu.Items)
                {
                    hungryCustomer.Items.Add(currentMenuItem);
                }
            }


            Console.WriteLine("Your total is {0} ", hungryCustomer.Total);

            Console.ReadLine();
        }
    }
}