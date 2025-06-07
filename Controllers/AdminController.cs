// Controllers/AdminController.cs
using coffeeshop.Models.Services;
using CoffeShop.Models;
using CoffeShop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

public class AdminController : Controller
{
    private IProductRepository productRepository;
    public AdminController(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    [Route("Admin")]
    public ActionResult Index()
    {
        return View();
    }

    [Route("Admin/Products")]
    public ActionResult Products()
    {
        var products = productRepository.GetAllProducts();
        return View(products);
    }

    public IActionResult CreateProduct()
    {
        return View();
    }



}