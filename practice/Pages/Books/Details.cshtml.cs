using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using practice.Models;
using practice.Services;

namespace practice.Pages.Books
{
    public class DetailsModel : PageModel
    {
        public Book Book { get; set; }

        public void OnGet(int id)
        {
            Book = BookService.GetById(id);
        }
    }
}
