#nullable disable

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

System.Console.WriteLine("___Tusk34____");      
System.Console.WriteLine("Enter Size: ");        
int Size = int.Parse(Console.ReadLine());         //задаем размер

int [] Massiv = Array(Size, 100, 999 );           // Метод на 60 строке
System.Console.Write("Это наш массив: ");
System.Console.WriteLine(String.Join(" ", Massiv));     

System.Console.WriteLine($"Кол-во четных чисел в массиве {arrayChet(Massiv)}");     // Метод на 72 строке





/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

System.Console.WriteLine("___Tusk36____");      
System.Console.WriteLine("Enter Size: ");        
int Size2 = int.Parse(Console.ReadLine());

int [] Massiv2 = Array(Size2, 0, 999 );           // Метод на 60 строке
System.Console.Write("Это наш массив: ");
System.Console.WriteLine(String.Join(" ", Massiv2));

System.Console.WriteLine($"Сумма не четных {arrayNeChet(Massiv2)}");    //// Метод на 91 строке 66





/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/



System.Console.WriteLine("___Tusk38____");      
System.Console.WriteLine("Enter Size: ");        
int Size3 = Convert.ToInt32(Console.ReadLine());

double [] Massiv3 = ArrayDouable(Size3, 0, 5 );           // Метод на 107 строке
System.Console.Write("Это наш массив: ");
System.Console.WriteLine(String.Join(" ; ", Massiv3));

System.Console.WriteLine($" Разница между Максимальноым и Минимальным значением = {MaxMin(Massiv3)}");  // Метод на 107 строке




int [] Array(int size, int min, int max)         // Метод для рандома
{
    int [] res = new int [size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max +1);
    }
    return res;
}


int arrayChet (int [] Array)                 // Метод для четных чисел
{
    int count = 0;
    for(int i = 0; i < Array.Length; i++)          
    {
        if (Array[i] % 2 == 0) 
        count++;
    }
    return count;
}







int arrayNeChet (int [] Array)                 // Метод для суммы не четных чисел
{
    int sum = 0;
    for(int i = 1; i < Array.Length; i+=2)
    {
        sum = sum + Array[i];
    }

    return sum;
}





double [] ArrayDouable(int size, int min, int max)         // Метод для рандома типа ДАБЛ
{
    double [] res = new double [size];

    for(int i = 0; i < size; i++)
    {
        res[i] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 1);    //Боже мой! Сделать вот это, было сложней чем все задачи, это капец....
    }
    return res;
}



double MaxMin(double [] Peremennaya)   //метод для разницы между макс и мин
{
    Double max = Peremennaya[0];
    Double min = Peremennaya[0];

    for(int i = 0; i < Peremennaya.Length; i++)
    {
        if(min > Peremennaya[i])
        {
            min = Peremennaya[i];
        }
        if(max < Peremennaya[i])
        {
            max = Peremennaya[i];
        }
    }
    return max - min;
}
