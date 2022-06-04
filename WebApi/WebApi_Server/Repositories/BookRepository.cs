using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WebApi_Common.Models;


namespace WebApi_Server_Konyvtar.Repositories
{
    public static class BookRepository
    {
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
            var rawData = JsonSerializer.Serialize(library);
            File.WriteAllText(filename, rawData);
        }
    }
}