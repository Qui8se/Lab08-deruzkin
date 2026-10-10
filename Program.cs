// int lessonNumber = 5;
// int totalLessons = 1;

// while (lessonNumber >= totalLessons)
// {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары закончились");









// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());

// int total = 0;

// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята: {grade}");
//     grade = int.Parse(Console.ReadLine());
//     total++;

// }
// Console.WriteLine("Ввод завершён");
// Console.WriteLine($"Кол-во введенных оценок: {total}");









// int sum = 0;
// int count = 0;
// int number = 0;

// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// while (grade != -1)
// {
//     sum += grade;
//     count++;
//     grade = int.Parse(Console.ReadLine());
//     if (grade > number)
//     {
//         number = grade;
//     }

// }
// if (count > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
// }else
// {
//     Console.WriteLine("Оценок не было введено");
// }
// Console.WriteLine($"Наибольшая из введенных оценок: {number}");










string correctPassword = "qwerty123";
int number = 0;
while (true)
{
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешён");
        break;
    }
    Console.WriteLine("Неверный пароль, попробуйте снова");
    number++;
}
Console.WriteLine($"Кол-во неудачных попыток: {number}");