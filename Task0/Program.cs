// Задача. Напишите прогамму, которая  
// 1. На вход принимает число 
// 2. Выдает его квадрат (число умноженное на само себя)

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
// Команды int.Parse и Convert.ToInt32 - преобразует строку в целое число, 
//чтобы проводить математические операции
int square = num * num;
Console.Write($"Квадрат числа {num} = {square}");
