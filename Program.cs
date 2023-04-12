//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console. Clear();
Console.WriteLine("                         ЗАДАЧА 2. МАКСИМАЛЬНОЕ ИЗ ДВУХ ЧИСЕЛ");
Console.WriteLine("Введите число 1: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
int Max = Num1;

if (Max > Num2)
{
    Console.WriteLine($"Максимальное число MAX равно: {Max}");
}
else if (Max < Num2)
{
    Max = Num2;
    Console.WriteLine($"Максимальное число MAX равно: {Max}");
}
else
{
    Console.WriteLine($"Введенные числа равны между собой, т.е.МАХ равно: {Max}");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("                         ЗАДАЧА 4. МАКСИМАЛЬНОЕ ИЗ ТРЕХ ЧИСЕЛ");

Console.WriteLine("Введите число 1: ");
int Nbr1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int Nbr2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int Nbr3 = Convert.ToInt32(Console.ReadLine());
int Max3 = Nbr1;

if (Max3 < Nbr2)
{
    Max3 = Nbr2;
}
if (Max3 < Nbr3)
{
    Max3 = Nbr3;
}

Console.WriteLine($"Максимум равен {Max3}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("                         ЗАДАЧА 6. ЧЕТНОЕ ЧИСЛО");

Console.WriteLine("Введите число для проверки четности: ");
int Numb = Convert.ToInt32(Console.ReadLine());
if (Numb % 2 == 0)
{
Console.WriteLine($"Введеное число {Numb} является ЧЕТНЫМ");
}
else
{
Console.WriteLine($"Введеное число {Numb} является НЕЧЕТНЫМ");
}


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("                         ЗАДАЧА 8. ЧЕТНЫЕ ЧИСЛА");

Console.WriteLine("Введите число N до которого нужно сосчитать четные числа: ");
int NumbN = Convert.ToInt32(Console.ReadLine());
int it = 1;

while (it<=NumbN)
{
if (it % 2 == 0)
{
    Console.WriteLine($"Четное число {it}");
}
it = it + 1;
}