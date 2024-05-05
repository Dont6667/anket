using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите ваш возраст: ");
        int age = Convert.ToInt32(Console.ReadLine());

       
        Console.Write("Введите дату вашего рождения (в формате ДД.ММ.ГГГГ): ");
        DateTime birthDate = Convert.ToDateTime(Console.ReadLine());

        Console.WriteLine("\nИмя: " + name);
        Console.WriteLine("Возраст: " + age);
        Console.WriteLine("Дата рождения: " + birthDate.ToShortDateString());






    }
}