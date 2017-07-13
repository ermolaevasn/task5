using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание5
{
    class Program
    {
        static void Main(string[] args)        
        {
            int[,] mas = new int[10, 10];//создание матрицы размером 10
            int i=0,j=0,max=0;
            Random r = new Random();
            for (int m = 0; m < 10; m++) //заполнение матрицы
                for (int n = 0; n < 10; n++)
                {
                    mas[m, n] = r.Next(-50, 50);
                }
            for (int m = 0; m < 10; m++)// вывод матрицы на экран
            {
                for (int n = 0; n < 10; n++)
                {
                    Console.Write("{0,5}", mas[m, n]);
                }
                Console.WriteLine();
            }
            do
            {
                if (mas[i,j]<0) //проверка на отрицательный элемент в главной диагонали
                {
                    max = mas[i, 0];
                    for (int k = 1; k < 10; k++)
                    {
                        if (mas[i, k] > max) max = mas[i, k]; // нахождение максимума
                    }
                    Console.WriteLine("В "+ (i+1)+ " строке максимальный элемент = "+ max);//вывод результата
                }
             i++;
             j++;
            } while (i<10);

            Console.ReadKey();       
        }
    }
}
