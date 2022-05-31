using System.Text.Json;
using WebApi_Common.Models;


namespace WebApi_Server_Konyvtar.Repositories
{
    public static class BookRepository
    {
        /*
        private const string filename = "Book.json";

        public static IEnumerable<Book> GetLibrary()
        {
            if (File.Exists(filename))
            {
                var rawData = File.ReadAllText(filename);
                var library = JsonSerializer.Deserialize<IEnumerable<Book>>(rawData);
                return library;
            }

            return new List<Book>();
        }

        public static void StoreLibrary(IEnumerable<Book> library)
        {
            var AppDataPath = GetAppDataPath(); 
            var rawData = JsonSerializer.Serialize(library);
            File.WriteAllText(filename, rawData);
        }*/

        public static IList<Book> GetLibrary()
        {
            using (var database = new BookContext())
            {
                var library = database.book.ToList();
                return library; 
            }
        }

        public static Book Getbook(int id)
        {
            using (var database = new BookContext())
            {
                var onebook = database.book.Where(p=> p.Id == id).FirstOrDefault();
                return onebook;
            }
        }
        public static void Addbook(Book book)
        {
            using (var database = new BookContext())
            {
                database.book.Add(book);

                database.SaveChanges();
            }

        }

        public static void DeleteBook(Book book)
        {
            using (var database = new BookContext())
            {
                database.book.Remove(book);

                database.SaveChanges();
            }

        }
        public static void UpdateBook(Book book, int id)
        {
            using (var database = new BookContext())
            {
                
                    database.book.Update(book);
                    database.SaveChanges();

                
        
            }
        }


    }
}
