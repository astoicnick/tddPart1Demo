using ClassLib.Interfaces;
using ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Services
{
    public class MockProductService : IProductService
    {
        private List<Product> _products = new List<Product>();
        public CreateResult CreateProduct(ProductCreateModel productCreateModel)
        {
            Product productToCreate = new Product()
            {
                Description = productCreateModel.Description,
                Price = productCreateModel.Price
            };
            try
            {
                _products.Add(productToCreate);
                return new CreateResult()
                {
                    IsSuccessful = true
                };
            }
            catch (Exception ex)
            {
                return new CreateResult()
                {
                    Errors = new List<string>() { ex.ToString() }
                };
            }
        }
    }
}
