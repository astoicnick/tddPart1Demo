using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Models
{
    public interface IProduct
    {
        int ProductId { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
        DateTime DateCreated { get; set; }
    }
}
