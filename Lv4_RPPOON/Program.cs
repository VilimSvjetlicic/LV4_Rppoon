using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv4_RPPOON
{
    class Program
    {
        
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            //2. zadatak

            Dataset dataset = new Dataset();
            dataset.LoadDataFromCSV("D:\\Users\\Korisnik\\Desktop\\lv4.txt");
            Analyzer3rdParty analyzer3rdParty = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer3rdParty);
            double[] column = adapter.CalculateAveragePerColumn(dataset);
            double[] row = adapter.CalculateAveragePerRow(dataset);
            int i = 0;
            Console.WriteLine("Stupci:");
            for (i = 0; i < column.Length; i++)
            {
                Console.Write(column[i] + " ");
            }
            Console.WriteLine("\nRedovi:");
            for (i = 0; i < row.Length; i++)
            {
                Console.Write(row[i] + " ");
            }

            //3. zadatak

            RentingConsolePrinter printer = new RentingConsolePrinter();
            List<IRentable> rent = new List<IRentable>();
            Book book = new Book("Kiklop");
            Video video = new Video("Casablanca");
            rent.Add(book);
            rent.Add(video);
            Console.WriteLine("Items:");
            printer.DisplayItems(rent);
            Console.WriteLine("Price:");
            printer.PrintTotalPrice(rent);

            //4. zadatak

            //Primjeæujem da se pri ispisu ispred HotItem-a pojavljuje "Trending:"

            RentingConsolePrinter printer = new RentingConsolePrinter();
            List<IRentable> rent = new List<IRentable>();
            Book book = new Book("Kiklop");
            Video video = new Video("Casablanca");
            rent.Add(book);
            rent.Add(video);

            Book hotBook = new Book("The Silent Patient");
            HotItem hotItemBook = new HotItem(hotBook);
            Video hotVideo = new Video("Once Upon a Time in ... Hollywood");
            HotItem hotItemVideo = new HotItem(hotVideo);
            rent.Add(hotItemBook);
            rent.Add(hotItemVideo);

            Console.WriteLine("Items:");
            printer.DisplayItems(rent);
            Console.WriteLine("Price:");
            printer.PrintTotalPrice(rent);

            //5. zadatak

            RentingConsolePrinter printer = new RentingConsolePrinter();
            Book book = new Book("Kiklop");
            Video video = new Video("Casablanca");
            Book hotBook = new Book("The Silent Patient");
            HotItem hotItemBook = new HotItem(hotBook);
            Video hotVideo = new Video("Once Upon a Time in ... Hollywood");
            HotItem hotItemVideo = new HotItem(hotVideo);
            List<IRentable> flashSale = new List<IRentable>();

            DiscountedItem discount1 = new DiscountedItem(book);
            DiscountedItem discount2 = new DiscountedItem(video);
            DiscountedItem discount3 = new DiscountedItem(hotItemBook);
            DiscountedItem discount4 = new DiscountedItem(hotItemVideo);
            flashSale.Add(discount1);
            flashSale.Add(discount2);
            flashSale.Add(discount3);
            flashSale.Add(discount4);

            Console.WriteLine("Items:\n");
            printer.DisplayItems(flashSale);
            Console.WriteLine("\nPrice:\n");
            printer.PrintTotalPrice(flashSale);
            Console.WriteLine();

            //6. zadatak

            String mail = "vilim.svjetlicic@gmail.com";
            string password = "Ovojesifra74";
            PasswordValidator passwordValidator = new PasswordValidator(5);
            EmailValidator emailValidator = new EmailValidator();
            if ((passwordValidator.IsValidPassword(password)) && (emailValidator.IsValidAddress(mail)))
            {
                Console.WriteLine("Valid email and password.");
            }
            else Console.WriteLine("Invalid email or password.");

        }
    }
}
