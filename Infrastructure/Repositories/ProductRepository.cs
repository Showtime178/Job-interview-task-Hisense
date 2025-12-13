using Infrastructure.Data;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        /// <summary>
        ///Kreiraj novi izdelek, če je šifra že v rabi vrži exception
        /// </summary>
        public void Create (Product product) 
        {
            if (!InMemoryDatabase.Products.Any(x => x.Code == product.Code))
            {
                InMemoryDatabase.Products.Add(product);
            }
            else
            {
                throw new ArgumentException("Tale šifra je že v rabi.", "Code");
            }
        }

        /// <summary>
        /// Pridobi izdelek po njegovem ID 
        /// </summary>
        public Product? GetItemById(string id)
        {
            return InMemoryDatabase.Products.FirstOrDefault(x => x.Code == id);
        }

        /// <summary>
        /// Pridobi vse izdelke 
        /// </summary>
        public IEnumerable<Product> GetAll()
        {
            return InMemoryDatabase.Products; 
        }

        /// <summary>
        /// Posodobi že obstoječi izdelek
        /// </summary>
        public bool Update(string id, Product product)
        {
            var existingProduct = InMemoryDatabase.Products.FirstOrDefault(x => x.Code == id);
            if (existingProduct == null)
            {
                return false;
            }

            existingProduct.Model = product.Model;
            existingProduct.Height = product.Height;
            existingProduct.Width = product.Width;
            existingProduct.Depth = product.Depth;
            return true;
        }

        /// <summary>
        /// Izbriši že obstoječi izdelek
        /// </summary>
        public bool Delete(string id)
        {
            var existingProduct = InMemoryDatabase.Products.FirstOrDefault(x => x.Code == id);
            if (existingProduct == null)
            {
                return false;
            }

            InMemoryDatabase.Products.Remove(existingProduct);
            return true;
        }
    }
}
