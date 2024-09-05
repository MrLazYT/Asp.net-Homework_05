using practice.Models;

namespace practice.Services
{
	public static class GenreService
	{
		public static List<Genre> Genres { get; set; }

		public static void Seed()
		{
			Genres = new List<Genre>()
			{
				new Genre()
				{
					Title = "Fantasy"
				},
				new Genre()
				{
					Title = "Novel"
				},
				new Genre()
				{
					Title = "IT"
				},
				new Genre()
				{
					Title = "Science fiction"
				}
			};
		}

		public static List<Genre> GetAll() => Genres;
	}
}
