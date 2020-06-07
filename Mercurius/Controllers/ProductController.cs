using Mercurius.Application.Services;
using Mercurius.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mercurius.Controllers
{
    public class ProductController : Controller
    {
        ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        
        // GET: Product
        public ActionResult Index()
        {
            var productListViewModel = _productService.GetAllProductsViewModel();
            return View(productListViewModel);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var productsViewModel = _productService.GetAllProductsViewModel();
            return View(productsViewModel);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            var productViewModel = _productService.GetNewProductViewModel();
            return View(productViewModel);
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel productViewModel)
        {
            productViewModel.Vendors = _productService.GetVendorsSelectList();

            if (ModelState.IsValid)
            {
                try
                {
                    _productService.Create(productViewModel);

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(productViewModel);
                }
            }
            else 
            {
                return View(productViewModel);
            }
                        
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                _productService.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: Product/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id)
        //{

        //}
    }
}