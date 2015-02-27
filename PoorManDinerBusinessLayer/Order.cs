using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PoorManDinerBusinessLayer
{
   public class Order
    {
       public Order()
       {
           Items = new List<MenuItem>();
       }
       public List<MenuItem> Items { get; set; }

       public double Total
       {
           get
           {
               double calculateTotal = 0;
               foreach (MenuItem item in Items)
               {
                   calculateTotal = calculateTotal + item.Price;
               }
               return calculateTotal;
           }
       }
    }
}
