using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlowerStore.Domain.Abstract;
using FlowerStore.WebUI.Models;

namespace FlowerStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;


        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }

        public ViewResult List(string category, int page = 1)
        {
            ProductListViewModel viewModel = new ProductListViewModel
            {
                Products = repository.Products.Where(x => category == null || x.Category == category).
                    OrderBy(x => x.ProductID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                        CurrentPage = page,
                        ItemsPerPage = PageSize,
                        TotalItems = repository.Products.Count(x => category == null || x.Category == category)
                },

                CurrentCategory = category

            };

            return View(viewModel);
        }
    }
}