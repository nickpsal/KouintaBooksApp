﻿// <auto-generated />
using KouintaBooksApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KouintaBooksApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240210130129_InitialData")]
    partial class InitialData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shared.Models.KouintaBook", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookID"));

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("bookPriceWVatND")
                        .HasColumnType("real");

                    b.Property<string>("bookTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("bookYear")
                        .HasColumnType("int");

                    b.Property<float>("finalBookPrice")
                        .HasColumnType("real");

                    b.Property<float>("finalBookPriceNoVat")
                        .HasColumnType("real");

                    b.Property<string>("publisherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookID");

                    b.ToTable("KouintaBooks");

                    b.HasData(
                        new
                        {
                            BookID = 1,
                            ISBN = "978-618-80515-1-5",
                            bookPriceWVatND = 12f,
                            bookTitle = "Μετά το γιώτα της ίωσης",
                            bookYear = 2013,
                            finalBookPrice = 8.4f,
                            finalBookPriceNoVat = 7.92f,
                            publisherName = "Τσοτάκος, Σπύρος"
                        },
                        new
                        {
                            BookID = 2,
                            ISBN = "978-618-80515-0-8",
                            bookPriceWVatND = 12f,
                            bookTitle = "Τα πλήθη του ενός",
                            bookYear = 2013,
                            finalBookPrice = 8.4f,
                            finalBookPriceNoVat = 7.92f,
                            publisherName = "Τσέχος, Ηλίας"
                        },
                        new
                        {
                            BookID = 3,
                            ISBN = "978-618-80515-3-9",
                            bookPriceWVatND = 22f,
                            bookTitle = "Εισαγωγή στον κινηματογράφο",
                            bookYear = 2014,
                            finalBookPrice = 15.4f,
                            finalBookPriceNoVat = 14.53f,
                            publisherName = "Χρηστος Καρακάσης"
                        },
                        new
                        {
                            BookID = 4,
                            ISBN = "978-618-80515-4-6",
                            bookPriceWVatND = 15f,
                            bookTitle = "Take a Trip to the Invisible Cities",
                            bookYear = 2014,
                            finalBookPrice = 10.5f,
                            finalBookPriceNoVat = 9.91f,
                            publisherName = "Κάππα, Βασιλική"
                        },
                        new
                        {
                            BookID = 5,
                            ISBN = "978-618-80515-2-2",
                            bookPriceWVatND = 8f,
                            bookTitle = "The Girlfriend",
                            bookYear = 2014,
                            finalBookPrice = 5.6f,
                            finalBookPriceNoVat = 5.28f,
                            publisherName = "Kelly, Tim"
                        },
                        new
                        {
                            BookID = 6,
                            ISBN = "978-618-80515-5-3",
                            bookPriceWVatND = 7f,
                            bookTitle = "Διεθνές Φεστιβάλ Ψηφιακού Κινηματογράφου",
                            bookYear = 2014,
                            finalBookPrice = 4.9f,
                            finalBookPriceNoVat = 4.62f,
                            publisherName = "-"
                        },
                        new
                        {
                            BookID = 7,
                            ISBN = "978-618-82109-0-5",
                            bookPriceWVatND = 12f,
                            bookTitle = "Eleni's Poetic Stories",
                            bookYear = 2015,
                            finalBookPrice = 8.4f,
                            finalBookPriceNoVat = 7.92f,
                            publisherName = "Ζόχντη - Μπλέτση, Ελένη"
                        },
                        new
                        {
                            BookID = 8,
                            ISBN = "978-618-80515-9-1",
                            bookPriceWVatND = 17f,
                            bookTitle = "Ήταν ένα Μικρό Τσαρούχι",
                            bookYear = 2015,
                            finalBookPrice = 11.9f,
                            finalBookPriceNoVat = 11.23f,
                            publisherName = "Βαρσάμης, Δημήτρης"
                        },
                        new
                        {
                            BookID = 9,
                            ISBN = "978-618-80515-7-7",
                            bookPriceWVatND = 12f,
                            bookTitle = "Ένα αστέρι στη Γη",
                            bookYear = 2015,
                            finalBookPrice = 8.4f,
                            finalBookPriceNoVat = 7.92f,
                            publisherName = "Λιτσοπούλου, Μαρία"
                        },
                        new
                        {
                            BookID = 10,
                            ISBN = "978-618-80515-8-4",
                            bookPriceWVatND = 12f,
                            bookTitle = "Η θυσία",
                            bookYear = 2015,
                            finalBookPrice = 8.4f,
                            finalBookPriceNoVat = 7.92f,
                            publisherName = "Μαρή Στέλλα"
                        },
                        new
                        {
                            BookID = 11,
                            ISBN = "978-618-80515-6-0",
                            bookPriceWVatND = 15f,
                            bookTitle = "Ρεμπέτικη ραψωδία",
                            bookYear = 2015,
                            finalBookPrice = 10.5f,
                            finalBookPriceNoVat = 9.91f,
                            publisherName = "Γκουζιώτης, Δημήτρης"
                        },
                        new
                        {
                            BookID = 12,
                            ISBN = "978-618-82109-1-2",
                            bookPriceWVatND = 20f,
                            bookTitle = "Οι παλιοί κινηματογράφοι της Αθήνας",
                            bookYear = 2015,
                            finalBookPrice = 14f,
                            finalBookPriceNoVat = 13.21f,
                            publisherName = "Θεοδοσίου, Νίκος"
                        },
                        new
                        {
                            BookID = 13,
                            ISBN = "978-618-82109-6-7",
                            bookPriceWVatND = 14f,
                            bookTitle = "Φωταύγεια ",
                            bookYear = 2016,
                            finalBookPrice = 9.8f,
                            finalBookPriceNoVat = 9.25f,
                            publisherName = "Χρηστος Καρακάσης"
                        },
                        new
                        {
                            BookID = 14,
                            ISBN = "978-618-82109-8-1",
                            bookPriceWVatND = 14f,
                            bookTitle = "Σε Χρώμα Κόκκινο",
                            bookYear = 2016,
                            finalBookPrice = 9.8f,
                            finalBookPriceNoVat = 9.25f,
                            publisherName = "Καλουμένου Άρτεμις"
                        },
                        new
                        {
                            BookID = 15,
                            ISBN = "978-618-82109-9-8",
                            bookPriceWVatND = 14f,
                            bookTitle = "Οι χορευτές των φαναριών",
                            bookYear = 2016,
                            finalBookPrice = 9.8f,
                            finalBookPriceNoVat = 9.25f,
                            publisherName = "Κάππα Βασιλική"
                        },
                        new
                        {
                            BookID = 16,
                            ISBN = "978-618-82109-7-4",
                            bookPriceWVatND = 14f,
                            bookTitle = "Ρέπλικα",
                            bookYear = 2016,
                            finalBookPrice = 9.8f,
                            finalBookPriceNoVat = 9.25f,
                            publisherName = "Μαρή Στέλλα"
                        },
                        new
                        {
                            BookID = 17,
                            ISBN = "978-618-82109-5-0",
                            bookPriceWVatND = 12f,
                            bookTitle = "Οι ποιητικές ιστορίες",
                            bookYear = 2016,
                            finalBookPrice = 8.4f,
                            finalBookPriceNoVat = 7.92f,
                            publisherName = "Ζόχντη - Μπλέτση, Ελένη"
                        },
                        new
                        {
                            BookID = 18,
                            ISBN = "978-618-82109-2-9",
                            bookPriceWVatND = 12f,
                            bookTitle = "ΤΟ ΤΑΞΙΔΙ ΜΟΛΙΣ ΤΩΡΑ ΑΡΧΙΖΕΙ ",
                            bookYear = 2016,
                            finalBookPrice = 8.4f,
                            finalBookPriceNoVat = 7.92f,
                            publisherName = "Συλλογικό έργο"
                        },
                        new
                        {
                            BookID = 19,
                            ISBN = "978-618-82109-3-6",
                            bookPriceWVatND = 15f,
                            bookTitle = "Το Μαύρο Αλφαβητάρι της Μουσικής",
                            bookYear = 2016,
                            finalBookPrice = 10.5f,
                            finalBookPriceNoVat = 9.91f,
                            publisherName = "Περιστέρης, Φίλιππος"
                        },
                        new
                        {
                            BookID = 20,
                            ISBN = "978-618-5268-00-8",
                            bookPriceWVatND = 14f,
                            bookTitle = "Οι γάτες της Αφρικής",
                            bookYear = 2016,
                            finalBookPrice = 9.8f,
                            finalBookPriceNoVat = 9.25f,
                            publisherName = "Πέτρου Μαρία"
                        },
                        new
                        {
                            BookID = 21,
                            ISBN = "978-618-82109-4-3",
                            bookPriceWVatND = 12f,
                            bookTitle = "The Duchess",
                            bookYear = 2016,
                            finalBookPrice = 8.4f,
                            finalBookPriceNoVat = 7.92f,
                            publisherName = "Kelly, Tim"
                        },
                        new
                        {
                            BookID = 22,
                            ISBN = "978-618-5268-01-5",
                            bookPriceWVatND = 14f,
                            bookTitle = "Ανυποχώρητοι έρωτες",
                            bookYear = 2017,
                            finalBookPrice = 9.8f,
                            finalBookPriceNoVat = 9.25f,
                            publisherName = "Καρτέρης Γιάννης"
                        },
                        new
                        {
                            BookID = 23,
                            ISBN = "978-618-5268-02-2",
                            bookPriceWVatND = 14f,
                            bookTitle = "Ανθρώπινο Τσίρκο",
                            bookYear = 2017,
                            finalBookPrice = 9.8f,
                            finalBookPriceNoVat = 9.25f,
                            publisherName = "Καϊμάκη Κέλλυ"
                        },
                        new
                        {
                            BookID = 24,
                            ISBN = "978-618-5268-03-9",
                            bookPriceWVatND = 14f,
                            bookTitle = "Ο πλανήτης",
                            bookYear = 2017,
                            finalBookPrice = 9.8f,
                            finalBookPriceNoVat = 9.25f,
                            publisherName = "Μαρή Στέλλα"
                        },
                        new
                        {
                            BookID = 25,
                            ISBN = "978-618-5268-04-6",
                            bookPriceWVatND = 14f,
                            bookTitle = "Η μετακόμιση",
                            bookYear = 2017,
                            finalBookPrice = 9.8f,
                            finalBookPriceNoVat = 9.25f,
                            publisherName = "Χρηστος Καρακάσης"
                        },
                        new
                        {
                            BookID = 26,
                            ISBN = "978-618-5268-05-3",
                            bookPriceWVatND = 15f,
                            bookTitle = "Ψαλμός στη σιωπή",
                            bookYear = 2018,
                            finalBookPrice = 10.5f,
                            finalBookPriceNoVat = 9.91f,
                            publisherName = "Τριανταφυλλίδη, Νίκη"
                        },
                        new
                        {
                            BookID = 27,
                            ISBN = "978-618-5268-06-0",
                            bookPriceWVatND = 14f,
                            bookTitle = "Ποιητική Συλλογή \\μῆτις\\\"\"",
                            bookYear = 2018,
                            finalBookPrice = 9.8f,
                            finalBookPriceNoVat = 9.25f,
                            publisherName = "Χρηστος Καρακάσης"
                        },
                        new
                        {
                            BookID = 28,
                            ISBN = "978-618-5268-07-7",
                            bookPriceWVatND = 12f,
                            bookTitle = "Ο ευτυχισμένος πρίγκιπας",
                            bookYear = 2018,
                            finalBookPrice = 8.4f,
                            finalBookPriceNoVat = 7.92f,
                            publisherName = "Wilde, Oscar, 1854-1900"
                        },
                        new
                        {
                            BookID = 29,
                            ISBN = "978-618-5268-08-4",
                            bookPriceWVatND = 14f,
                            bookTitle = "Στιγμές που εκβάλλουν στο αιώνιο",
                            bookYear = 2021,
                            finalBookPrice = 9.8f,
                            finalBookPriceNoVat = 9.25f,
                            publisherName = "Μπούσιος, Ηλίας"
                        },
                        new
                        {
                            BookID = 30,
                            ISBN = "978-618-5268-09-1",
                            bookPriceWVatND = 12f,
                            bookTitle = "Και να θυμάσαι",
                            bookYear = 2021,
                            finalBookPrice = 8.4f,
                            finalBookPriceNoVat = 7.92f,
                            publisherName = "Θυμιανού, Αλεξάνδρα Ι."
                        },
                        new
                        {
                            BookID = 31,
                            ISBN = "978-618-5268-10-7",
                            bookPriceWVatND = 14f,
                            bookTitle = "Ροές ψυχής",
                            bookYear = 2022,
                            finalBookPrice = 9.8f,
                            finalBookPriceNoVat = 9.25f,
                            publisherName = "Μπούσιος, Ηλίας"
                        },
                        new
                        {
                            BookID = 32,
                            ISBN = "978-618-5268-11-4",
                            bookPriceWVatND = 14f,
                            bookTitle = "Λοιπόν; Τι σκέφτεστε;",
                            bookYear = 2023,
                            finalBookPrice = 9.8f,
                            finalBookPriceNoVat = 9.25f,
                            publisherName = "Θυμιανού, Αλεξάνδρα Ι."
                        },
                        new
                        {
                            BookID = 33,
                            ISBN = "978-618-5268-12-1",
                            bookPriceWVatND = 18f,
                            bookTitle = "Όλα για την Ελίζα",
                            bookYear = 2023,
                            finalBookPrice = 12.6f,
                            finalBookPriceNoVat = 11.89f,
                            publisherName = "Κυριακάκη, Μαριάννα"
                        },
                        new
                        {
                            BookID = 34,
                            ISBN = "978-618-5268-13-8",
                            bookPriceWVatND = 14f,
                            bookTitle = "Βαλς κάρδαμου κανέλας",
                            bookYear = 2023,
                            finalBookPrice = 9.8f,
                            finalBookPriceNoVat = 9.25f,
                            publisherName = "Παυλιδάκη, Μαίρη"
                        },
                        new
                        {
                            BookID = 35,
                            ISBN = "978-618-5268-15-2",
                            bookPriceWVatND = 20f,
                            bookTitle = "Στα χνάρια του Φεδερίκο Γκαρθία Λόρκα",
                            bookYear = 2023,
                            finalBookPrice = 14f,
                            finalBookPriceNoVat = 13.21f,
                            publisherName = "Μπούσιος, Ηλίας"
                        },
                        new
                        {
                            BookID = 36,
                            ISBN = "978-618-5268-14-5",
                            bookPriceWVatND = 18f,
                            bookTitle = "Η αρπαγή του φεγγαριού",
                            bookYear = 2023,
                            finalBookPrice = 12.6f,
                            finalBookPriceNoVat = 11.89f,
                            publisherName = "Ανωγειάτης, Γιώργος"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
