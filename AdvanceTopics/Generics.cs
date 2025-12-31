using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceTopics
{
    internal class GenericsStore<T, U>
    {
        //public T Value;

        List<T> Products = new List<T>();
        Dictionary<U, T> Productdict = new Dictionary<U, T>();
        public void AddProduct(T product, U id)
        {
            Products.Add(product);
            Productdict.Add(id, product);
        }

        public List<T> GetAllProduct()
        {
            //    Console.WriteLine(Products);   
            return Products;
        }
        internal T GetProductbyId(U id)
        {
            return Productdict[id];
        }
    }
}
