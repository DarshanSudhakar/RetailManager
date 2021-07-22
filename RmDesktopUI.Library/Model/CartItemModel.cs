using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmDesktopUI.Library.Model
{
    public class CartItemModel
    {
        public ProductModel Product { get; set; }

        public int QuantityInCart
        {
            get;
            set;
        }

        public string DisplayName
        {
            get
            {
                return $"{ Product.Name } ({ QuantityInCart })";
            }
        }
    }
}
