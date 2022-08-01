using System;

namespace tel
{

    public class Contacts
    {

        List<Person> list = new List<Person>();

        public Contacts()
        {

            list.Add(new Person { Ad = "Ali", Soyad = "Kılıç", Tel = "05555555551" });
            list.Add(new Person { Ad = "Ahmet", Soyad = "Meç", Tel = "05555555552" });
            list.Add(new Person { Ad = "Mehmet", Soyad = "Orak", Tel = "05555555553" });
            list.Add(new Person { Ad = "Ayşe", Soyad = "Balta", Tel = "05555555554" });
            list.Add(new Person { Ad = "Veli", Soyad = "Bıçak", Tel = "05555555555" });

        }


        public void Add()
        {
            Person person = new Person();
            System.Console.WriteLine("(1) Yeni Kişi Kaydetme Ekranı");
            System.Console.WriteLine("Adı giriniz:");
            person.Ad = Console.ReadLine();
            System.Console.WriteLine("Soyadı giriniz:");
            person.Soyad = Console.ReadLine();
            System.Console.WriteLine("Telefon numarası giriniz:");
            person.Tel = Console.ReadLine();

            list.Add(person);

            System.Console.WriteLine("Kişi başarıyla eklendi.");
            System.Console.WriteLine(list[list.Count - 1].Ad + " " + list[list.Count - 1].Soyad + " " + list[list.Count - 1].Tel);
        }

        public void Delete()
        {

            string arama;
            int tryagain = 2;
            bool found;

            while (tryagain == 2)
            {

                System.Console.WriteLine("(2) Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                arama = Console.ReadLine();
                found = false;

                foreach (Person item in list)
                {
                    if ((item.Ad).ToLower() == arama.ToLower() || (item.Soyad).ToLower() == arama.ToLower())
                    {
                        found = true;
                        System.Console.WriteLine(item.Ad + " " + item.Soyad + " : " + item.Tel + " kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                        if (Console.ReadLine() == "y")
                        {
                            list.Remove(item);
                            System.Console.WriteLine("Kişi başarıyla silindi.");
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("Kişi silme işlemi iptal edildi.");
                            tryagain = 2;
                            break;
                        }
                    }
                }


                if (!found)
                {
                    System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    System.Console.WriteLine("* Silmeyi sonlandırmak için : (1)");

                    System.Console.WriteLine("* Yeniden denemek için      : (2)");
                    string karar = Console.ReadLine();
                    if (karar == "1")
                    {
                        Console.WriteLine("Menüden çıkış yapılıyor...");

                        Program.Main();
                    }
                    else if (karar == "2")
                    {
                        tryagain = 2;
                    }
                    else
                    {
                        System.Console.WriteLine("Geçersiz seçim yaptınız. Ana menüye yönlendiriliyorsunuz....");
                        break;
                    }

                }

            }

        }

        public void Update()
        {
            string arama;
            int tryagain = 2;
            bool found;

            while (tryagain == 2)
            {

                System.Console.WriteLine("(3) Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                arama = Console.ReadLine();
                found = false;

                foreach (Person item in list)
                {
                    if ((item.Ad).ToLower() == arama.ToLower() || (item.Soyad).ToLower() == arama.ToLower())
                    {
                        found = true;
                        System.Console.WriteLine(item.Ad + " " + item.Soyad + " : " + item.Tel + " kişi rehberden güncellemek üzere, onaylıyor musunuz ?(y/n)");
                        if (Console.ReadLine() == "y")
                        {
                            System.Console.WriteLine("Adını giriniz:");
                            item.Ad = Console.ReadLine();
                            System.Console.WriteLine("Soyadı giriniz:");
                            item.Soyad = Console.ReadLine();
                            System.Console.WriteLine("Telefon numarası giriniz:");
                            item.Tel = Console.ReadLine();
                            System.Console.WriteLine("Kişi başarıyla güncellendi.");
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("Kişi güncelleme işlemi iptal edildi.");
                            tryagain = 2;
                            break;
                        }
                    }
                }
                if (!found)
                {
                    System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    System.Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                    System.Console.WriteLine("* Yeniden denemek için sonlandırmak için : (2)");

                    string karar = Console.ReadLine();
                    if (karar == "1")
                    {
                        Console.WriteLine("Menüden çıkış yapılıyor...");

                        Program.Main();
                    }
                    else if (karar == "2")
                    {
                        tryagain = 2;
                    }
                    else
                    {
                        System.Console.WriteLine("Geçersiz seçim yaptınız. Ana menüye yönlendiriliyorsunuz....");
                        break;
                    }


                }
            }
        }

        public void ListAll()
        {
            System.Console.WriteLine("(4) Kişilerin listesi");
            foreach (Person item in list)
            {
                System.Console.WriteLine(item.Ad + " " + item.Soyad + " : " + item.Tel);
            }
            System.Console.WriteLine("ESC ile ana menüye dönebilirsiniz");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Program.Main();
            }

        }

        public void Search()
        {
            System.Console.WriteLine("(5) Kişi arama");
            System.Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            System.Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");
            bool found;
            string arama;
            string telno;


            string karar = Console.ReadLine();
            if (karar == "1")
            {

                System.Console.WriteLine("Lütfen aramak istediğiniz kişinin ismini ya soyismini giriniz:");
                arama = Console.ReadLine();
                found = false;

                if (list.Count == 0)
                {
                    System.Console.WriteLine("Rehberde hiç kişi bulunmamaktadır.");
                }
                else
                {
                    foreach (Person item in list)
                    {
                        if ((item.Ad).ToLower() == arama.ToLower() || (item.Soyad).ToLower() == arama.ToLower())
                        {
                            found = true;
                            System.Console.WriteLine(item.Ad + " " + item.Soyad + " : " + item.Tel);
                        }
                        else
                        {
                            found = false;
                        }
                    }
                    if (!found)
                    {
                        System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                    }
                }

                if (karar == "2")
                {
                    System.Console.WriteLine("Lütfen aramak istediğiniz kişinin telefon numarasını giriniz:");
                    telno = Console.ReadLine();
                    found = false;

                    if (list.Count == 0)
                    {
                        System.Console.WriteLine("Rehberde hiç kişi bulunmamaktadır.");
                    }
                    else
                    {
                        foreach (Person item in list)
                        {
                            if (item.Tel == telno)
                            {
                                found = true;
                                System.Console.WriteLine(item.Ad + " " + item.Soyad + " : " + item.Tel);
                            }
                            else
                            {
                                found = false;
                            }
                        }
                        if (!found)
                        {
                            System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                        }
                    }

                }

                System.Console.WriteLine("ESC ile ana menüye dönebilirsiniz");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Program.Main();
                }

            }



        }

    }


}