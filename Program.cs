/* ----------------------------------------------------------------------------------------------
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
------------------------------------------------------------------------------------------------*/
/*
int [] CreateArray ()
{
 Console.Write("Input size of massive: ");
 int size = Convert.ToInt32(Console.ReadLine());
 int[] newArr = new int[size];
    for (int i = 0; i <= newArr.Length-1; i++)
 {
    Console.WriteLine($"Input element of massive with index {i}: ");
    newArr[i] = Convert.ToInt32(Console.ReadLine());;
 }
 return newArr;
}

int FindCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count += 1;
    }
    return count;
}

int res = FindCount(CreateArray());
Console.WriteLine($"User input positive numbers in count: {res}");
*/

/* ----------------------------------------------------------------------------------------------
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
------------------------------------------------------------------------------------------------*/
/*
void FindPoint(double b1, double k1, double b2, double k2)
{  
    double x = 0;
    double y = 0;

    if (b1 == b2 && k1 == k2) Console.WriteLine("Прямые совпадают");
    if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны, пересечений нет");
    if (k1 != k2 && b1 != b2) 
        {
            x = (b2 - b1) / (k1 - k2);
            y = k1*x + b1;
            Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");
        } 
      
}

Console.Write("Input number b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input number k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input number b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input number k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

FindPoint(b1, k1, b2, k2);
*/