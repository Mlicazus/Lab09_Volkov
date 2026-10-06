// for (int room = 5; room <= 50; room += 5)
// {
//     Console.WriteLine($"Кабинет {room}");
// }

// int totalWeeks = 3;
// for (int week =1; week <= totalWeeks; week++)
// {
//     for (int day = 1; day <= 5; day++)
//     {
//         Console.WriteLine($"Неделя {week}, день {day}");
//     }
//     Console.WriteLine("^_^");
// }

// int count = 0;
// for (int ticket = 1; ticket <= 30; ticket++)
// {
//     if (ticket == 4 || ticket == 12 || ticket == 19)
//     {
//         count++;
//         continue; // билет уже вытянут
//     }
//     Console.WriteLine($"Первый доступный билет: {ticket}");
//     Console.WriteLine($"Пропущено: {count}");
//     break;
// }

// for (; ; )
// {
//     Console.Write("Введите код группы (для выхода - 'выход'): ");
//     string groupCode = Console.ReadLine();
//     if (groupCode == "exit") // с "выход" не работает.
//     {
//         break;
//     }
//     Console.WriteLine($"Записан код группы: {groupCode}");
// }
// Console.WriteLine("Работа с журналом завершена");

// // Задача А
// int n = 50;
// for (int number = 1; number <= n; number++)
// {
//     if (number % 2 != 0)
//     {
//         Console.WriteLine(number);
//     }
// }

// // Задача Б
// for (int number = 100; number >= 0; number -= 10)
// {
//     Console.WriteLine(number);
// }

// System.Console.Write("Введите свою фамилию: ");
// string surname = System.Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname))
// {
//     System.Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// System.Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// // Вариант 2
// int M = 1;
// Console.WriteLine();
// for (int N = 10; N >= 0; N -= M)
// {
//     Console.WriteLine(N);
// }

// Вариант 9
int N = 5;
int sum = 0;
for (int number = 1; number <= N; number++)
{
    if (number % 5 == 0)
    {
        continue;
    }
    sum += number;
}
Console.WriteLine($"Сумма всех чисел от 1 до {N}, пропуская числа, кратные 5: {sum}");