//Задача 6
//Является ли число чётным

Console.WriteLine("Пожалуйста, введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write($"Число {number} является чётным!");
}
else
{
    Console.Write($"Число {number} является нечётным!");
}