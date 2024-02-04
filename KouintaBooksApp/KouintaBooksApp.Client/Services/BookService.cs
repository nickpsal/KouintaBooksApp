using Shared.BookRepositories;
using Shared.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace KouintaBooksApp.Client.Services
{
    public class BookService : IBookRepo
    {
        public readonly HttpClient HttpCilent;

        public BookService(HttpClient httpCilent)
        {

            HttpCilent = httpCilent;

        }
        public async Task<KouintaBook> AddBookAsync(KouintaBook model)
        {
            var book = await HttpCilent.PostAsJsonAsync("api/book/new", model);
            var response = await book.Content.ReadFromJsonAsync<KouintaBook>();
            return response!;
        }

        public async Task<KouintaBook> DeleteBookAsync(int BookID)
        {
            var book = await HttpCilent.DeleteAsync("api/book/delete/{BookID}");
            var response = await book.Content.ReadFromJsonAsync<KouintaBook>();
            return response!;
        }

        public async Task<List<KouintaBook>> GetAllBooksAsync()
        {
            var books = await HttpCilent.GetAsync("api/book/all");
            var response = await books.Content.ReadFromJsonAsync<List<KouintaBook>>();
            return response!;
        }

        public async Task<KouintaBook> GetBookByID(int BookID)
        {
            var book = await HttpCilent.GetAsync("api/book/{BookID}");
            var response = await book.Content.ReadFromJsonAsync<KouintaBook>();
            return response!;
        }

        public async Task<KouintaBook> UpdateBookAsync(KouintaBook model)
        {
            var book = await HttpCilent.PutAsJsonAsync("api/book/update/", model);
            var response = await book.Content.ReadFromJsonAsync<KouintaBook>();
            return response!;
        }
    }
}
