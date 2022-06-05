using Microsoft.AspNetCore.Mvc;

namespace SportStore.AddControllersWithViews;

public class HomeController : Controller
{
    public IActionResult Index() => View();
}