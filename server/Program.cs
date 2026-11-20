Console.WriteLine("Привет");
Console.WriteLine("ФИО: Саидов Бахмуд Мирзаевич");
Console.WriteLine("Группа: ИСП-243");
Console.WriteLine("Дата и время: " + DateTime.Now);

string a = "";
while (a != "4")
{
    Console.WriteLine("1 — Показать ФИО");
    Console.WriteLine("2 — Показать группу");
    Console.WriteLine("3 — Показать дату");
    Console.WriteLine("4 — Выход");
    a = Console.ReadLine();

    if (a == "1")
    {
        Console.WriteLine("Саидов Бахмуд Мирзаевич");
    }
    if (a == "2")
    {
        Console.WriteLine("ИСП-243");
    }
    if (a == "3")
    {
        Console.WriteLine("20.11.2026");
    }
}
