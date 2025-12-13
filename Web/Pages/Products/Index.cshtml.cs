using Microsoft.AspNetCore.Mvc.RazorPages;
using Infrastructure.Repositories;
using Infrastructure.Models;

namespace Web.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IRepository<Product> _repository;

        public IEnumerable<Product> Products { get; private set; } = new List<Product>();
    
        public IndexModel(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            Products = _repository?.GetAll() ?? new List<Product>();
        }
    }
}
