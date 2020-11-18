using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MG_asp_lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace MG_asp_lab2.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository repository)
        {
            this.productRepository = repository;
        }
        public ViewResult List() => View(productRepository.Products);

        public IActionResult Index()
        {
            return View();
        }


    }
}
