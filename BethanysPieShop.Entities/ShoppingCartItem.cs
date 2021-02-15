using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShop.Entities
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }

        public Pie Pie { get; set; }

        public int Amount { get; set; } 

        public string ShoppingCartId { get; set; }
    }
}
