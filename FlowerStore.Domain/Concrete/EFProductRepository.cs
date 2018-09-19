using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerStore.Domain.Abstract;
using FlowerStore.Domain.Entities;

namespace FlowerStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
