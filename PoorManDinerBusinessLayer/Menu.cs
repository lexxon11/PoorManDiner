using System.Collections.Generic;
using PoorManDiner.Business.dsPoorManDinerTableAdapters;
namespace PoorManDiner.Business
{
    public class Menu
    { 
        //Constructor
        public Menu()
        {
            Items = new List<MenuItem>();
        }
        //field allows us to save new items to menu by id
        private int _databaseId;

        //our save new menu item method
        public void SaveNewMenuItem(string name, string description, double price)
        {
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();
            taMenuItem.InsertNewMenuItem(Name, description, price, _databaseId);
        }
        public static List<Menu> GetAllMenus()
        {
            MenuTableAdapter taMenu = new MenuTableAdapter();
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();
            var dtMenu = taMenu.GetData();
            List<Menu> allMenus = new List<Menu>();
            foreach (dsPoorManDiner.MenuRow menuRow in dtMenu.Rows)
            {
                Menu currentMenu = new Menu();
                currentMenu.Name = menuRow.Name;
                currentMenu._databaseId = menuRow.Id;
                allMenus.Add(currentMenu);

                var dtMenuItems = taMenuItem.GetMenuItemsByMenuId(menuRow.Id);
                foreach (dsPoorManDiner.MenuItemRow menuItemRow in dtMenuItems.Rows)
                {
                    currentMenu.AddMenuItem(menuItemRow.Name,menuItemRow.Description, menuItemRow.Price);
                }
            }
            return allMenus;
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