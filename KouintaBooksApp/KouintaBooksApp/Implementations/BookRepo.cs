using KouintaBooksApp.Data;
using Microsoft.EntityFrameworkCore;
using Shared.BookRepositories;
using Shared.Models;

namespace KouintaBooksApp.Implementations
{
    public class BookRepo : IBookRepo
    {
        private readonly AppDbContext DbContext;

        public BookRepo(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<KouintaBook> AddBookAsync(KouintaBook model)
        {
            if (model == null) return null!;
            var checkifexists = await DbContext.KouintaBooks.Where(b => b.bookTitle.ToLower() == model.bookTitle.ToLower()).FirstOrDefaultAsync();
            if (checkifexists is not null)
            {
                return null!;
            }
            var modelReturn = DbContext.KouintaBooks.Add(model).Entity;
            await DbContext.SaveChangesAsync();
            return modelReturn;
        }

        public async Task<KouintaBook> DeleteBookAsync(int BookID)
        {
            var bookToDelete = await DbContext.KouintaBooks.FirstOrDefaultAsync(b => b.BookID == BookID);
            if (bookToDelete is null)
            {
                return null!;
            }
            DbContext.KouintaBooks.Remove(bookToDelete);
            await DbContext.SaveChangesAsync();
            return bookToDelete;
        }

        public async Task<List<KouintaBook>> GetAllBooksAsync() => await DbContext.KouintaBooks.ToListAsync();

        public async Task<KouintaBook> GetBookByID(int BookID)
        {
            var getBookByID = await DbContext.KouintaBooks.FirstOrDefaultAsync(b => b.BookID == BookID);
            if (getBookByID is null)
            {
                return null!;
            }
            return getBookByID;
        }

        public async Task<KouintaBook> UpdateBookAsync(KouintaBook model)
        {
            var UpdateBook = await DbContext.KouintaBooks.FirstOrDefaultAsync(b => b.BookID == model.BookID);
            if (UpdateBook is null)
            {
                return null!;
            }
            UpdateBook.bookTitle = model.bookTitle;
            UpdateBook.publisherName = model.publisherName;
            UpdateBook.bookYear = model.bookYear;
            UpdateBook.bookPriceWVatND = model.bookPriceWVatND;
            UpdateBook.finalBookPriceNoVat = model.bookPriceWVatND;
            UpdateBook.finalBookPrice = model.finalBookPrice;
            KouintaBook? updatedBook =  await DbContext.KouintaBooks.FirstOrDefaultAsync(b => b.BookID == model.BookID);
            return updatedBook!;
        }
    }
}
