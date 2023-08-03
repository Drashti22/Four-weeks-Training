    using Microsoft.AspNetCore.Mvc;

namespace ProductsWebApp.Controllers
{
    public class ProductController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            Product product = RetrieveProductById(id);

            // Created an instance of DetailsViewModel and set its properties
            DetailsViewModel viewModel = new DetailsViewModel();
            viewModel.Product = product;
            viewModel.DisplayMessage = "This is the display message for the Details view.";

            return View(viewModel);
        }
        [HttpPost]
     
        public IActionResult Create(Product product)
        {
            // Save the product data to a database or perform other operations
            // Return the product data in the response
            return Json(product);
        }
        public ActionResult Create()
        {
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {

            return Json(product);
        }
        public ActionResult Edit()
        {

            return View()
        }

        public ActionResult Delete(int id)
        {
            return View(id);
        }
    }


        //public ActionResult Index()
        //{
        //    return Content("This is the IndexAction");                                      
        //}
        //public ActionResult Details(int id)
        //{
        //    return Content("This is the DetailsAction");
        //}
        //public ActionResult Create()
        //{
        //    return Content("This is the CreateAction");
        //}
        //public ActionResult Edit(int id)
        //{
        //    return Content("This is the IndexAction");
        //}
        //public ActionResult Delete(int id)
        //{
        //    return Content("This is the DeleteAction");
        //}
    }
}
