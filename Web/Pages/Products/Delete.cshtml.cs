using Infrastructure.Models;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Products
{
    public class DeleteModel : PageModel
    {
        private readonly IRepository<Product> _repository;

        [BindProperty]
        public Product Product { get; private set; } = new Product();

        public DeleteModel(IRepository<Product> repository) => _repository = repository;

        public IActionResult OnGet(string code) 
        {
            var existingProduct = _repository.GetItemById(code);

            if (existingProduct == null)
            {
                return NotFound();
            }

            Product = new Product
            {
                Code = existingProduct.Code
            };

            return Page();
        }

        public IActionResult OnPost(string code)
        {
            var ok = _repository.Delete(code);

            if (!ok) 
            {
                return NotFound();
            }

            return RedirectToPage("/Products/Index");
        }
    }
}
