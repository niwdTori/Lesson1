// Задача 8
//Все чётные числа от 1 до N

Console.WriteLine("Пожалуйста, введите число: ");
int number = int.Parse(Console.ReadLine());

for (int numberA = 1; numberA <= number; numberA++)
    if (numberA % 2 == 0)
    {
        Console.Write(numberA + " ");
    }
    
