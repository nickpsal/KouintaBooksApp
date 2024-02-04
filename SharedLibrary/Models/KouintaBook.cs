using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models
{
    public class KouintaBook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; set; }
        public string bookTitle { get; set; }
        public string publisherName { get; set; }
        public int bookYear { get; set; }
        public float bookPriceWVatND { get; set; }
        public float finalBookPriceNoVat { get; set; }
        public float finalBookPrice { get; set; }
        public string ISBN { get; set; }
    }
}
