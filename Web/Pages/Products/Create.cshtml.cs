using Infrastructure.Models;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly IRepository<Product> _repository;

        [BindProperty]
        public Product Product { get; set; } = new Product();

        public CreateModel(IRepository<Product> repository) => _repository = repository;

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repository.Create(Product);
            return RedirectToPage("/Products/Index");
        }
    }
}
