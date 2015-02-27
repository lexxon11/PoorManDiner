using System.Collections.Generic;

namespace PoorManDiner.Business
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
