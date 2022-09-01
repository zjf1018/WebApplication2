using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApplication2.Models
{
    public class Order
    {
        [Key]
        [BindNever] 
        public int OrderID { get; set; }

        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [BindNever]
        public bool Shipped { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter the address")]
        public string Line1 { get; set; }


    }
}
