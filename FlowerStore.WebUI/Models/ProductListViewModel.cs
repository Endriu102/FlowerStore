using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlowerStore.Domain.Entities;

namespace FlowerStore.WebUI.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}