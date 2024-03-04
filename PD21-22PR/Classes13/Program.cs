using System;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            Document document = new Document("Контракт");
            document.Body = "Тіло контракта...";
            document.Footer = "Директор: Іванов І.І.";

            document.Show();

            Console.ReadKey();
        }
    }
}
