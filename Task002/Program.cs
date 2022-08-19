//Задача 2
//Какое число большее, какое меньшее

Console.WriteLine("Пожалуйста, введите первое число: ");
int FirstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите второе число: ");
int SecondNumber = int.Parse(Console.ReadLine());

if (FirstNumber > SecondNumber) 
{
    Console.Write("Первое число больше: ");
    Console.Write(FirstNumber);
    Console.Write(", второе число меньше: ");
    Console.Write(SecondNumber);
}
else
{
    Console.Write("Второе число больше: ");
    Console.Write(SecondNumber);
    Console.Write(", первое число меньше: ");
    Console.Write(FirstNumber);
}