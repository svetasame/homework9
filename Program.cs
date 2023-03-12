static int Prompt(string message)
{
  System.Console.WriteLine(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int NumbersFrom1ToN(int n)
{
  if (n <= 0) return 0;
  else
    System.Console.Write(n + " ");
  return NumbersFrom1ToN(n - 1);
}

int SummsFromMToN(int m, int n)
{
  if (n == m && n > 0 && m > 0) return m;
  else if (m < 0 && n < 0) return 0;
  else if (n < 0 && m > 0) return SummsFromMToN(m, n + 1);
  else if (m < 0 && n > 0) return SummsFromMToN(m + 1, n);
  else
  {
    if (m <= n) return m + SummsFromMToN(m + 1, n);
    else return n + SummsFromMToN(m, n + 1);
  }
}

int Akkerman(int n, int m)
{
  if (m < 0 || n < 0) return 0;
  else
  {
    if (n == 0) return m + 1;
    else
    {
      if ((n != 0) && (m == 0)) return Akkerman(n - 1, 1);
      else return Akkerman(n - 1, Akkerman(n, m - 1));
    }
  }
}

// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = Prompt ("введите число");
System.Console.WriteLine($"натуральные числа от {n} до 1:");
NumbersFrom1ToN(n);

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = Prompt ("введите 1 число");
int n = Prompt ("введите 2 число");
System.Console.WriteLine($"сумма натуральных чисел от {m} до {n}:");
System.Console.WriteLine(SummsFromMToN(m, n));

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 95
// m = 3, n = 2 -> A(m,n) = 29

int n = Prompt ("введите 1 число");
int m = Prompt ("введите 2 число");
System.Console.WriteLine($"функция Аккермана от {m} до {n}:");
System.Console.WriteLine(Akkerman (n, m));