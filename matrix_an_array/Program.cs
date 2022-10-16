using System.Linq;
using System.Data.Common;
using System.Drawing;


/*
 * двухмерный массив
 * ввод размерности массива и матрицы
 * найти количество положительных/отрицательных чисел в матрице
*/

  int positive=0, negative=0;
{
    
    Console.WriteLine("Введите размерность массива");
    int n = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());

    int[,] mas = new int[n, m];
    Random rn = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            mas[i, j] = rn.Next(11) - 5;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            Console.Write(String.Format("{0,3}", mas[i, j]));
        Console.WriteLine();
        
    }
   //выводим положительные элементы
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (mas[i, j] > 0)
                ++positive;
            //Console.WriteLine(mas[i, j]);
            
        }
    }
    //выводим отрицательные элементы
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (mas[i, j] < 0)
                ++negative;
                //Console.WriteLine(mas[i, j]);
            
        }
    }
    Console.WriteLine($"Количество положительных чисел в массиве:{positive}");
    Console.WriteLine($"Количество отрицательных чисел в массиве:{negative}");
}
