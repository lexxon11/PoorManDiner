using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoorManDinerConsole
{
    public class Menu
    { 
        public Menu()
        {
            Items = new List<MenuItem>();
        }
        public string Name { get; set; }
        public List<MenuItem> Items { get; set; }

        public void AddMenuItem(string title, string description, double price)
        {
            var item = new MenuItem {Price = price, Title = title, Description = description};
            Items.Add(item);
        }
    }
}