using System.Collections.Generic;
using System.Linq;

namespace MG_asp_lab2.Models
{
    public interface IProductRepository 
    {
        IQueryable<Product> Products { get; }

    }
}
