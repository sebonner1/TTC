namespace database.Models
{
    public class Book
    {
        public string Title{get; set;}
        public string Author{get; set;}

        public int Id {get; set;}

        public ISave SaveBehavior{get; set;}

        public Book()
        {
            SaveBehavior = new SaveBooks();
        }
    }
}