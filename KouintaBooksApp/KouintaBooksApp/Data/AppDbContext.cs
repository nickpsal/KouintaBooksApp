using KouintaBooksApp.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using OfficeOpenXml;
using Shared.Models;

namespace KouintaBooksApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<KouintaBook> KouintaBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            List<KouintaBook> Books = ReadDataFromExcel();            
            modelBuilder.Entity<KouintaBook>().HasData(Books);
        }

        public List<KouintaBook> ReadDataFromExcel()
        {
            int Id = 1;
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
                            BookID = Id,
                            bookTitle = bookTitle,
                            publisherName = publisherName,
                            bookYear = bookYear,
                            bookPriceWVatND = bookPriceWVatND,
                            finalBookPriceNoVat = finalBookPriceNoVat,
                            finalBookPrice = finalBookPrice,
                            ISBN = ISBN
                        };
                        bookList.Add(book);
                        Id++;
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
    }
}
