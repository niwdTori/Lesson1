//Задача 4
//Максимальное число из 3 чисел

Console.WriteLine("Пожалуйста, введите первое число: ");
int FirstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите второе число: ");
int SecondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите третье число: ");
int ThreeNumber = int.Parse(Console.ReadLine());

int max = FirstNumber;

if (FirstNumber > max ) max = FirstNumber;
if (SecondNumber > max ) max = SecondNumber;
if (ThreeNumber > max ) max = ThreeNumber;

Console.Write("max = ");
Console.Write(max);

