using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using practice.Models;
using practice.Services;

namespace practice.Pages.Books
{
    public class EditModel : PageModel
    {
        public Book Book { get; set; } = default!;
		public List<Genre> Genres { get; set; } = default!;

        public void OnGet(int id)
        {
			Book = BookService.GetById(id);
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

			BookService.Update(Book);

			return RedirectToPage("Index");
		}
	}
}
