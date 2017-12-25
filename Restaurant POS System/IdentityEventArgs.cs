using System.Collections.Generic;

namespace Restaurant_POS_System
{
    public class IdentityEventArgs
    {
        public Item item { get; set; }
        public List<Sales> sales { get; set; }
        public IdentityEventArgs(Item item)
        {
            this.item = item;
        }

        public IdentityEventArgs(List<Sales> sales)
        {
            this.sales = sales;
        }
    }
}