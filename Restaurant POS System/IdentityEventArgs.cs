using System.Collections.Generic;

namespace Restaurant_POS_System
{
    public class IdentityEventArgs
    {
        public Item item { get; set; }
        public IdentityEventArgs(Item item)
        {
            this.item = item;
        }
    }
}