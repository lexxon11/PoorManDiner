using System.Collections.Generic;

namespace PoorManDiner.Business
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