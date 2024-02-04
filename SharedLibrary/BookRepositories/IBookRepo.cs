using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.BookRepositories
{
    public interface IBookRepo
    {
        Task<KouintaBook> AddBookAsync(KouintaBook model);
        Task<KouintaBook> UpdateBookAsync(KouintaBook model);
        Task<KouintaBook> DeleteBookAsync(int BookID);
        Task<List<KouintaBook>> GetAllBooksAsync();
        Task<KouintaBook> GetBookByID(int BookID);
    }
}
