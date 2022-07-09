// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int Recursion(int i, int j, int sum = 0)
{
    if (i+1>=j) return sum; // промежуток между числами, не включая самих чисел
    sum = sum + i+1;
    return Recursion(i+1, j, sum);
}
if (m<n) 
{
    Console.WriteLine ($"Сумма всех натуральных элементов в промежутке от {m} до {n}: {Recursion(m, n)}");
}
else Console.WriteLine ($"Введите иные значения, где M меньше N");