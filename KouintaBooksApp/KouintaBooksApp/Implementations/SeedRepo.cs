using KouintaBooksApp.Data;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using Shared.BookRepositories;
using Shared.Models;
using SharedLibrary.SeedRepositories;
using SharedLibrary.SharedRepo;

namespace KouintaBooksApp.Implementations
{
    public class SeedRepo : ISeedService
    {
        private readonly AppDbContext dbContext;
        private readonly IBookRepo bookRepo;

        public SeedRepo(AppDbContext dbContext, IBookRepo bookRepo)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            this.dbContext = dbContext;
            this.bookRepo = bookRepo;
        }

        private async Task MigrateDatabaseAsync()
        {
#if DEBUG
            if ((await dbContext.Database.GetPendingMigrationsAsync()).Any())
            {
                await dbContext.Database.MigrateAsync();
            }

#endif
        }

        public async Task<List<KouintaBook>> ReadDataFromExcel()
        {
            string filePath = "Data/books.xlsx";
            List<KouintaBook> bookList = new();
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);
                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Assuming data is in the first sheet
                    int rowCount = worksheet.Dimension.Rows;
                    for (int row = 2; row <= rowCount; row++) // Assuming the first row contains headers
                    {
                        string bookTitle = worksheet.Cells[row, 1].Text;
                        string publisherName = worksheet.Cells[row, 2].Text;
                        int bookYear = int.Parse(worksheet.Cells[row, 3].Text);
                        float bookPriceWVatND = float.Parse(worksheet.Cells[row, 4].Text);
                        float finalBookPriceNoVat = float.Parse(worksheet.Cells[row, 5].Text);
                        float finalBookPrice = float.Parse(worksheet.Cells[row, 6].Text);
                        string ISBN = worksheet.Cells[row, 7].Text;
                        KouintaBook book = new KouintaBook()
                        {
                            bookTitle = bookTitle,
                            publisherName = publisherName,
                            bookYear = bookYear,
                            bookPriceWVatND = bookPriceWVatND,
                            finalBookPriceNoVat = finalBookPriceNoVat,
                            finalBookPrice = finalBookPrice,
                            ISBN = ISBN
                        };
                        await bookRepo.AddBookAsync(book);
                    }
                }
                return bookList;
            }
            catch (FileNotFoundException exp)
            {
                Console.WriteLine($"File not Found {exp.Message}");
                return bookList;
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Error: {exp.Message}");
                return bookList;
            }
        }

        public async Task SeedDataAsync()
        {
            await MigrateDatabaseAsync();
            if (dbContext.KouintaBooks.ToList().Count == 0 )
            {
                SharedServices.books = await ReadDataFromExcel();
            }
        }
    }
}
