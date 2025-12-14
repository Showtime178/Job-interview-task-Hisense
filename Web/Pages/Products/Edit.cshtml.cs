using Infrastructure.Models;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly IRepository<Product> _repository;

        [BindProperty]
        public Product Product { get; set; } = new Product();

        public EditModel(IRepository<Product> repository) => _repository = repository;

        public IActionResult OnGet(string code) 
        {
            var existingProduct = _repository.GetItemById(code);

            if (existingProduct == null)
            {
                return NotFound(); 
            }

            Product = new Product
            {
                Code = existingProduct.Code,
                Model = existingProduct.Model,
                Width = existingProduct.Width,
                Height = existingProduct.Height,
                Depth = existingProduct.Depth
            };

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var updatedProduct = new Product
            {
                Code = Product.Code,
                Model = Product.Model,
                Width = Product.Width,
                Height = Product.Height,
                Depth = Product.Depth
            };

            var ok = _repository.Update(Product.Code, updatedProduct);

            if (!ok) 
            {
                return NotFound();
            }

            return RedirectToPage("/Products/Index");
        }
    }
}
