// using System;

// class Program
// {
//     static void Main()
//     {
//         int age = 20;
//         double gra = 4.5;
//         bool isStudent = true;
//         string name = "Дима";

//         Console.WriteLine(age);
//         Console.WriteLine(gra);
//         Console.WriteLine(isStudent);
//         Console.WriteLine(name);
//     }
// }
    
using System;

class Program
{
    static void Main()
    {
        string firstName = "Дмитрий";
        string lastName = "Сташенко";
        string group = "ИСП-243";
        int birthYear = 2008;
        double gpa = 4.2;
        bool hasScholarship = false;

   
        int currentYear = 2026;
        int age = currentYear - birthYear;

        Console.WriteLine("Студенческое удостоверение");
        Console.WriteLine($"Имя: {firstName} {lastName}");
        Console.WriteLine($"Группа: {group}");
        Console.WriteLine($"Возраст: {age} лет");
        Console.WriteLine($"Средний балл: {gpa}");
        Console.WriteLine($"Стипендия: {hasScholarship}");

        Console.Write("\nВведите ваш любимый предмет: ");
        string subject = Console.ReadLine();
        Console.WriteLine($"Отлично! {firstName} любит {subject}.");
    }
}