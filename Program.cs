/* 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
больше 0 ввёл пользователь.
*/
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i =0; i<array.Length; i++)
    {
        Console.Write($"input {i+1} element of array: ");
        int element = Convert.ToInt32(Console.ReadLine());
        array[i] = element;
    }return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}
int SumOfPositive(int[] array)
{   
    int result=0;
    for (int i=0; i<array.Length; i++)
    {
        if(array[i] > 0) result++;
    }return result;
}

Console.WriteLine("Input the length of massive: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] MyArray=CreateArray(size);
ShowArray(MyArray);
int result = SumOfPositive(MyArray);
Console.WriteLine($"Sum of positive elements is: {result}");
*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
*/
void Crossing(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    if (k1 == k2)
    {
        if (b1 == b2) Console.WriteLine("Lines are applied");
        else Console.WriteLine("Lines are not crossed each other");
    }
    else Console.WriteLine($"lines are crossed here: ({x}, {y})");

}

Console.WriteLine("Input k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Crossing(k1,b1,k2,b2);
