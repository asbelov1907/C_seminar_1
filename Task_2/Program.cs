// See https://aka.ms/new-console-template for more information






Console.Write("Введите число А ->");

int numA = int.Parse(Console.ReadLine());

Console.Write("Введите число B ->");

int numB = int.Parse(Console.ReadLine());

int numResult = numB * numB;

if(numResult == numA)
{
   Console.Write("Число B является квадратом числа А"); 
}
else
{
Console.Write("Число B не является квадратом числа А");
}