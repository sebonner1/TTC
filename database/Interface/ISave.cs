namespace database
{
    public interface ISave
    {
         public void CreateBook();
         public void UpdateBook();
         public void SaveBook(Book myBook);
    }
}