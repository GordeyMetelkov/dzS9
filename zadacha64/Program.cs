// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// кратные 3-ём в промежутке от M до N.
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
void Recursion(int i, int j)
{
    if (i>j) return;
    else
    {
        if (i%3==0) 
        {
            Console.Write(i + "\t");
            Recursion(i+3, j);
        }
        else
        {
            i++;
            Recursion(i++, j);
        }
    }
}
if (m<n) 
{
    Console.WriteLine ($"Все числа, кратные трем от {m} до {n}:");
    Recursion(m, n);
}
else Console.WriteLine ($"Введите иные значения, где M меньше N");