using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Models
{
    class Product : IProduct
    {
        [Key]
        public int ProductId { get; set; } = 0;
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
