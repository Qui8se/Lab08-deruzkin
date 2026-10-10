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









// string answer;

// do
// {
//     Console.Write("Введите дату посещения (например, 01.09): ");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");

//     Console.Write("Добавить еще одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");
// Console.WriteLine("Дневник сохранён");







//Задача А

// Console.WriteLine("Введите число от 1 до 10: ");
// int number = int.Parse(Console.ReadLine());
// int count = 1;

// while (count <= 10)
// {
//     Console.WriteLine($"{number} * {count} = {number * count}");
//     count++;
// }












// Задача Б

// Console.WriteLine("Вводите имена учеников. Для завершения введите 'конец': ");
// string word = Console.ReadLine();
// int n = 0;

// while (word != "конец") {
//     n++;
//     Console.WriteLine($"Имя ученика: {word}");
//     word = Console.ReadLine();
// }
// Console.WriteLine($"Кол-во имён: {n}");



// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");







 //№1

// Console.WriteLine("Введите число N: ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine($"Обратный отсчет от {n} до 1: ");

// while (n >= 1)
// {
//     Console.WriteLine(n);
//     n--;
// }
// Console.WriteLine("Старт!");




//№7

// int n = 1;
// double count = 0;
// while (n <= 7)
// {
//     Console.WriteLine($"День {n}: ");
//     double temp = double.Parse(Console.ReadLine());
//     count += temp;
//     Console.WriteLine($"{n} день - {temp} градусов");
//     n++;
// }
// double average = count / 7;
// Console.WriteLine($"Средняя температура за неделю: {average}");