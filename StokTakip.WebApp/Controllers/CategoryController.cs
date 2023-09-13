using Microsoft.AspNetCore.Mvc;
using StokTakip.WebApp.Models;
using StokTakip.WebApp.Repository;
namespace StokTakip.WebApp.Controllers;

public class CategoryController : Controller
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }


    public IActionResult Index()
    {
        var categories = _categoryRepository.GetAll();
        return View(categories);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Category category)
    {
        _categoryRepository.Add(category);

        return RedirectToAction("Index","Category");

    }








}
