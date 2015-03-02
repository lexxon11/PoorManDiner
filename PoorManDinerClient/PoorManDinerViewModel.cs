using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using PoorManDiner.Business;

namespace PoorManDiner.Client
{
    public class PoorManDinerViewModel
    {
        public List<Menu> AllMenus {
            get
            {
                return Menu.GetAllMenus();
            } }
    }
}
