using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MG_asp_lab2.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products =>
        
            new List<Product>
            {
                new Product {ProductID= 1, Name="VR", Description="Rozgrywka VR", Price=400, Category="Elektronika"},
                new Product {ProductID= 2, Name="Byty Nike", Description="Buty sportowe", Price=80, Category="Obowie"},
                new Product {ProductID= 3, Name="T-shirt", Description="Podkoszulek", Price=40, Category="Odziez"},
            }.AsQueryable<Product>();

        
    }
}
