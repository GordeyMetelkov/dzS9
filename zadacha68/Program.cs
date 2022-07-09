// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double Akkerman (double m, double n)
{
    if (m == 0) return n+1;
    else if (n == 0) return Akkerman(m-1,1);
    else return Akkerman(m-1, Akkerman(m, n-1));
}
Console.WriteLine(Akkerman(M, N));