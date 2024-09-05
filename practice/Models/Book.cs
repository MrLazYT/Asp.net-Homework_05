namespace practice.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public string PublishingHouse { get; set; }
        public short Year { get; set; }
    }
}