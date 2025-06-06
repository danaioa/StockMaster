using System;
using System.Collections.Generic;
using StockMaster.DAL;

namespace StockMaster.BLL
{
    public class ProductService
    {
        private ProductRepository repository;

        public ProductService()
        {
            repository = new ProductRepository();
        }

        public List<Product> GetAllProducts()
        {
            return repository.GetAllProducts();
        }

        public List<Product> GetProductsByCategoryAndHotel(int categoryId, int hotelId)
        {
            return repository.GetProductsByCategoryAndHotel(categoryId, hotelId);
        }


        public void UpdateProduct(Product produs)
        {
            repository.Update(produs);
        }
        public void AddProduct(Product produsNou)
        {
            repository.AddProduct(produsNou);  
        }


    }
}
