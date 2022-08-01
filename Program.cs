using System;

namespace tel;

class Program
{
   public static void Main()
    {
        Console.WriteLine("Hoş geldiniz!");

        Contacts contacts = new Contacts();

        string cont = "";
        while (cont != "exit" || cont != "quit")
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz, \nProgramdan Çıkış için 'exit' ya da 'quit' giriniz");
            System.Console.WriteLine("*******************************************");
            System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
            System.Console.WriteLine("(2) Varolan Numarayı Silmek");
            System.Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            System.Console.WriteLine("(4) Rehberi Listelemek");
            System.Console.WriteLine("(5) Rehberde Arama Yapmak");


            cont = Console.ReadLine().ToLower();
            switch (cont)
            {
                case "1":
                    contacts.Add();
                    break;
                case "2":
                    contacts.Delete();
                    break;
                case "3":
                    contacts.Update();
                    break;
                case "4":
                    contacts.ListAll();
                    break;
                case "5":
                    contacts.Search();
                    break;
                case "exit": return;
                case "quit": return;
                default:
                    System.Console.WriteLine("1-5 arası program seçiniz ya da exit/quit ile çıkınız.");
                    break;
            }
        }

    }
}
