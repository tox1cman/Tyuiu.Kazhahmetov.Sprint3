﻿using Tyuiu.Kazhahmetov.Sprint3.Task7.V9.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Кажахметов А. Е. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнил: Кажахметов Амир Ерболович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = -5;

int stopValue = 5;

int len = stopValue - startValue + 1;

double[] valueArray;
valueArray = new double[len];

valueArray = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i <= len - 1; i++)
{ 
    Console.WriteLine(Convert.ToString(startValue) + "   " + valueArray[i]);
    startValue++;
}

Console.ReadKey();