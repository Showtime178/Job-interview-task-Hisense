using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public static class InMemoryDatabase
    {
        public static readonly List<Product> Products = new()
        {
            //Napolni in-memory database z nekaj primerkov za lažjo in hitrejšo testiranje
            new Product { Code = "RB5K330GSFD", Model = "Samostojni hladilnik z zamrzovalnikom", Height = 1856, Width = 595, Depth = 600 },
            new Product { Code = "RQ760N4IFE", Model = "Hi9 Samostojni štirivratni hladilnik", Height = 1785, Width = 914, Depth = 725 }
        };
    }
}
