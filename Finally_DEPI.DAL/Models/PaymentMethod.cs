using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finally_DEPI.DAL.Models
{
    public class PaymentMethod
    {
        
        public int Id { get; set; }
        public string PaymentName { get; set; }

        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }

    }
}
