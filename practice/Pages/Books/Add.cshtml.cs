using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using practice.Models;
using practice.Services;

namespace practice.Pages.Books
{
    public class AddModel : PageModel
    {
        public Book Book { get; set; }
        public List<Genre> Genres { get; set; }

        public void OnGet()
        {
            Genres = GenreService.GetAll();
        }

        public IActionResult OnPost(Book book, string selectedGenre)
        {
            Genres = GenreService.GetAll();

            Book = book;
            Book.Genre = Genres.FirstOrDefault(genre => genre.Title == selectedGenre)!;

			if (String.IsNullOrEmpty(Book.Title) ||
				String.IsNullOrEmpty(Book.Author) ||
				Book.Genre == null ||
				String.IsNullOrEmpty(Book.PublishingHouse) ||
				Book.Year < 0 ||
				Book.Year > 3000)
            {
                return Page();
            }
            
            BookService.Add(Book);

            return RedirectToPage("Index");
        }
    }
}
