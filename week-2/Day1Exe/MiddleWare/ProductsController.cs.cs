using Microsoft.AspNetCore.Mvc;


namespace MiddleWare
{
    [Route("products")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Index() { 
        return View();
        }
        [HttpGet("{id}")]
        public IActionResult Details(int id) {
            var product = $"Product details for ID: {id}";
            return Content(product);
        }
        [HttpGet("{id}/reviews")]
        public IActionResult Reviews(int id) {
            var reviews = $"Reviews for Product ID: {id}";
            return Content(reviews);
        }

    }
    
    }

