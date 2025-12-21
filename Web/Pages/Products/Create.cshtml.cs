using Infrastructure.Models;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Products
{
    public class CreateModel : PageModel
    {
        public string? WarningMessage { get; set; }
        public string? ErrorMessage { get; set; }

        private readonly IRepository<Product> _repository;

        [BindProperty]
        public Product Product { get; set; } = new Product();

        public CreateModel(IRepository<Product> repository) => _repository = repository;

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                WarningMessage = "Prosim izpolnite vsa polja";
                return Page();
            }

            var result = _repository.Create(Product);

            if (!result.Success)
            {
                ErrorMessage = result.Message;
                return Page();
            }

            return RedirectToPage("/Products/Index");
        }
    }
}
