﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlowerStore.Domain.Abstract;

namespace FlowerStore.WebUI.Controllers
{
    public class NavController : Controller
    {
        private readonly IProductRepository productRepository;

        public NavController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public PartialViewResult Menu()
        {
            IEnumerable<string> categories =
                productRepository.Products.Select(x => x.Category).Distinct().OrderBy(x => x);

            return PartialView(categories);
        }
    }
}