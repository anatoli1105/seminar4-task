﻿//Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. Оформите 
//заполнение массива и вывод в виде функции (пригодится в следующих задачах)1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
//6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1
int Promt(string messege)
{
    Console.WriteLine(messege);
    string strN = Console.ReadLine();
    int N =int.Parse(strN);
    return N;
}
int number = Promt("введите колличество элементов ");
int[] array = new int[number];
void Rand(int[] Set)
{
    int lenght = Set.Length;
    for(int i = 0;i < lenght;i++)
    {
        Set[i] = new Random().Next(1,100);
    }
}
void console(int[] Mas)
{
    int count = Mas.Length;
    for(int pos = 0; pos < count;pos++)
    {
        Console.Write(Mas[pos] + " ,");
    }
}

Rand(array);
console(array);


