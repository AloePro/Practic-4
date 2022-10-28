using ConsoleApp1;
internal class Program
{
    static void Main()
    {


        Zametka zametka1 = new Zametka();
        zametka1.Name = "Войти в почту";
        zametka1.Discruption = "Вспомнить пароль";
        zametka1.EndDate = new DateTime(2022, 9, 12);

        Zametka zametka2 = new Zametka();
        zametka2.Name = "Пойти в зал";
        zametka2.Discruption = "Потренировать ноги";
        zametka2.EndDate = new DateTime(2022, 10, 17);

        Zametka zametka3 = new Zametka();
        zametka3.Name = "Поговорить с мамой";
        zametka3.Discruption = "Спросить как у неё дела";
        zametka3.EndDate = new DateTime(2022, 11, 22);

        Zametka zametka4 = new Zametka();
        zametka4.Name = "Поиграть с котом";
        zametka4.Discruption = "Провести с ним время";
        zametka4.EndDate = new DateTime(2022, 12, 18);

        Zametka zametka5 = new Zametka();
        zametka5.Name = "Сходить в гараж";
        zametka5.Discruption = "Помочь Папе";
        zametka5.EndDate = new DateTime(2022, 9, 10);

        Zametka[] zametki = new Zametka[] { zametka1, zametka2, zametka3, zametka4, zametka5 };
        vvod(zametki);
    }
    static void vvod(Zametka[] zametki)
    {


        int b = 1;
        DateTime date = new DateTime(2022, 10, 25);
        ConsoleKeyInfo clavisha = Console.ReadKey();
        while (clavisha.Key != ConsoleKey.Escape)
        {
            ConsoleKeyInfo clav = Console.ReadKey();
            while (clav.Key != ConsoleKey.Enter)
            {

                if (clav.Key == ConsoleKey.LeftArrow)
                {
                    date = date.AddDays(-1);
                }
                else if (clav.Key == ConsoleKey.RightArrow)
                {
                    date = date.AddDays(1);
                }
                if (clav.Key == ConsoleKey.UpArrow)
                {
                    b--;
                }
                else if (clav.Key == ConsoleKey.DownArrow)
                {
                    b++;
                }
                Console.Clear();

                Console.WriteLine(date.Date);
                foreach (Zametka item in zametki)
                {
                    if (item.EndDate == date)
                    {
                        Console.WriteLine("  " + item.Name);
                    }
                }
                Console.SetCursorPosition(0, b);
                Console.WriteLine("->");

                clav = Console.ReadKey();
            }
            Zametka[] zametki2 = zametki.Where(item => item.EndDate == date).ToArray();
            Console.Clear();
            Console.WriteLine(zametki2[b - 1].Discruption);
            clavisha = Console.ReadKey();
        }
    }
}