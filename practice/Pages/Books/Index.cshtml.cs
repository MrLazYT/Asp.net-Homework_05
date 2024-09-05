using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using practice.Models;
using practice.Services;

namespace practice.Pages.Books
{
    public class IndexModel : PageModel
    {
        public List<Book> Books { get; set; }
        
		public void OnGet()
        {
			Books = BookService.GetAll();
        }

		public IActionResult OnPostDeleteBook(int id)
		{
			BookService.Delete(id);
			Books = BookService.GetAll();

			return Page();
		}

		public IActionResult OnPostSearch(string searchValue, string searchingType)
		{
			if (String.IsNullOrEmpty(searchValue))
			{
				Books = BookService.GetAll();
			}
			else if (searchingType == "byTitle")
			{
				Books = BookService.SearchByTitle(searchValue);
			}
			else if (searchingType == "byAuthor")
			{
				Books = BookService.SearchByAuthor(searchValue);
			}
			else if (searchingType == "byGenre")
			{
				Books = BookService.SearchByGenre(searchValue);
			}
			else if (searchingType == "byPublishingHouse")
			{
				Books = BookService.SearchByPublishingHouse(searchValue);
			}

			return Page();
		}
	}
}
