using System;
using ClassLib.Interfaces;
using ClassLib.Models;
using ClassLib.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ProductTests
    {
        private IProductService _productService;

        [TestMethod]
        public void CreateProducts()
        {
            // TODO: Create a product which is saved to
            var productCreateModel = new ProductCreateModel()
            {
                Description = "Kombucha",
                Price = 2.97m
            };
            _productService = new MockProductService();
            var productCreateResult = _productService.CreateProduct(productCreateModel);
            Assert.IsTrue(productCreateResult.IsSuccessful);
        }
        [TestMethod]
        public void GetIndividualProduct()
        {
            // TODO: Get a product entity by using the id
        }
        [TestMethod]
        public void GetListOfProducts()
        {
            // TODO: Create a product which is saved to db
        }
        [TestMethod]
        public void UpdateProduct()
        {
            // TODO: Update a product given an ID and a model with
            // updated properties
        }
        [TestMethod]
        public void DeleteProduct()
        {
            // TODO: Create a product which is saved to db
        }
    }
}
