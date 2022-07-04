using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyuuiiiWebsite.Models;

namespace MyuuiiiWebsite.Controllers;

public class HomeController : Controller
{
	private readonly ILogger<HomeController> _logger;

	public HomeController(ILogger<HomeController> logger)
	{
		_logger = logger;
	}

	[Route("")]
	public IActionResult Index()
	{
		return View();
	}

	[Route("socials")]
	public IActionResult Socials()
	{
		return View();
	}

	[Route("fumo"), Route("ᗜˬᗜ")]
	public IActionResult Fumo()
	{
		return View();
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
