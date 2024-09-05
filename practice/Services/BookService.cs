using practice.Models;

namespace practice.Services
{
    public static class BookService
    {
        private static int bookId = 1;
        private static List<Book> Books { get; set; }

        public static void Seed()
        {
            Books = new List<Book>()
            {
                new Book()
                {
                    Id = bookId++,
                    Title = "The Witcher: The Last Wish",
                    Author = "Andrzej Sapkowski",
                    Genre = new Genre()
				    {
					    Title = "Fantasy"
				    },
                    PublishingHouse = "KSD",
                    Year = 2009
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "The Witcher: Sword of Destiny",
                    Author = "Andrzej Sapkowski",
					Genre = new Genre()
					{
						Title = "Fantasy"
					},
					PublishingHouse = "KSD",
                    Year = 2010
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "The Witcher: Blood of Elves",
                    Author = "Andrzej Sapkowski",
					Genre = new Genre()
					{
						Title = "Fantasy"
					},
					PublishingHouse = "KSD",
                    Year = 2010
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "The Witcher: Time of Contempt",
                    Author = "Andrzej Sapkowski",
					Genre = new Genre()
					{
						Title = "Fantasy"
					},
					PublishingHouse = "KSD",
                    Year = 2011
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "The Witcher: Baptism of Fire",
                    Author = "Andrzej Sapkowski",
					Genre = new Genre()
					{
						Title = "Fantasy"
					},
					PublishingHouse = "KSD",
                    Year = 2011
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "The Witcher: Swallow Tower",
                    Author = "Andrzej Sapkowski",
					Genre = new Genre()
					{
						Title = "Fantasy"
					},
					PublishingHouse = "KSD",
                    Year = 2012
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "The Witcher: Lady of The Lake",
                    Author = "Andrzej Sapkowski",
					Genre = new Genre()
					{
						Title = "Fantasy"
					},
					PublishingHouse = "KSD",
                    Year = 2013
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "The Witcher: Season of Storms",
                    Author = "Andrzej Sapkowski",
					Genre = new Genre()
					{
						Title = "Fantasy"
					},
					PublishingHouse = "KSD",
                    Year = 2014
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "Clean Code",
                    Author = "Robert C. Martin",
					Genre = new Genre()
					{
						Title = "IT"
					},
					PublishingHouse = "FABULA",
                    Year = 2019
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "The Clean Coder",
                    Author = "Robert C. Martin",
					Genre = new Genre()
					{
						Title = "IT"
					},
					PublishingHouse = "FABULA",
                    Year = 2019
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "Clean Agile",
                    Author = "Robert C. Martin",
					Genre = new Genre()
					{
						Title = "IT"
					},
					PublishingHouse = "FABULA",
                    Year = 2019
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "Clean Architecture",
                    Author = "Robert C. Martin",
					Genre = new Genre()
					{
						Title = "IT"
					},
					PublishingHouse = "FABULA",
                    Year = 2019
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "The Queen's Gambit",
                    Author = "Walter Tevis",
					Genre = new Genre()
					{
						Title = "Novel"
					},
					PublishingHouse = "KSD",
                    Year = 2020
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "The Balad of The Songbirds and Snakes",
                    Author = "Suzanne Collins",
					Genre = new Genre()
					{
						Title = "Science fiction"
					},
					PublishingHouse = "BookChief",
                    Year = 2023
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "The Hunger Games",
                    Author = "Suzanne Collins",
					Genre = new Genre()
					{
						Title = "Science fiction"
					},
					PublishingHouse = "BookChief",
                    Year = 2023
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "The Hunger Games: Catching Fire",
                    Author = "Suzanne Collins",
					Genre = new Genre()
					{
						Title = "Science fiction"
					},
					PublishingHouse = "BookChief",
                    Year = 2023
                },
                new Book()
                {
                    Id = bookId++,
                    Title = "The Hunger Games: Mokingjay",
                    Author = "Suzanne Collins",
					Genre = new Genre()
					{
						Title = "Science fiction"
					},
					PublishingHouse = "BookChief",
                    Year = 2024
                },
            };
        }

        public static List<Book> GetAll() => Books;

        public static Book GetById(int id) => Books.FirstOrDefault(book => book.Id == id)!;

        public static void Add(Book book)
        {
            book.Id = bookId++;
			
            Books.Add(book);
        }

        public static void Update(Book book)
        {
			int index = Books.FindIndex(targetBook => targetBook.Id == book.Id);
			Books[index] = book;
        }

        public static void Delete(int id)
        {
            Book book = GetById(id);

            Books.Remove(book);
        }

        public static List<Book> SearchByTitle(string value)
        {
            string lowerValue = value.ToLower();

            IEnumerable<Book> BookEnum = Books.Where(
                book =>
                {
                    string lowerTitle = book.Title.ToLower();

                    return lowerTitle.Contains(lowerValue);
                });

            return BookEnum.ToList();
        }

		public static List<Book> SearchByAuthor(string value)
		{
			string lowerValue = value.ToLower();

			IEnumerable<Book> BookEnum = Books.Where(
				book =>
				{
					string lowerAuthor = book.Author.ToLower();

					return lowerAuthor.Contains(lowerValue);
				});

			return BookEnum.ToList();
		}

		public static List<Book> SearchByGenre(string value)
		{
			string lowerValue = value.ToLower();

			IEnumerable<Book> BookEnum = Books.Where(
				book =>
				{
					string lowerGenre = book.Genre.Title.ToLower();

					return lowerGenre.Contains(lowerValue);
				}
            );

			return BookEnum.ToList();
		}

		public static List<Book> SearchByPublishingHouse(string value)
		{
			string lowerValue = value.ToLower();

			IEnumerable<Book> BookEnum = Books.Where(
				book =>
				{
					string lowerPubHouse = book.PublishingHouse.ToLower();

					return lowerPubHouse.Contains(lowerValue);
				}
			);

			return BookEnum.ToList();
		}
	}
}