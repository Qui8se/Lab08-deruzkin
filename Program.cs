// int lessonNumber = 5;
// int totalLessons = 1;

// while (lessonNumber >= totalLessons)
// {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары закончились");









Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

int total = 0;

while (grade != -1)
{
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
    total++;

}
Console.WriteLine("Ввод завершён");
Console.WriteLine($"Кол-во введенных оценок: {total}");