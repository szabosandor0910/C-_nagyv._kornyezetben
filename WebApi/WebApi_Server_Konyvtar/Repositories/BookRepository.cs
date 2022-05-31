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
        public static void StoreLibrary(IList<Book> library)
        {
            var appDataPath = GetAppDataPath();
            var rawContext = JsonSerializer.Serialize(library);
            File.WriteAllText(appDataPath, rawContext); 
        }
        private static string GetAppDataPath()
        {
            var localAppFolder = GetLocalFolder();
            var AppDataPath = Path.Combine((string)localAppFolder, "Book.json");
            return AppDataPath;

        }

        private static object GetLocalFolder()
        {
            var localAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var localAppFolder = Path.Combine(localAppDataFolder, "WebApi_Server_Konyvtar");
            if(!Directory.Exists(localAppFolder))
            {
                Directory.CreateDirectory(localAppFolder);
            }
            return localAppFolder;
    }
}
