using Tyuiu.Kazhahmetov.Sprint3.Task5.V6.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Кажахметов А. Е. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Кажахметов Амир Ерболович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue1 = 1;
int startValue2 = 1;
int stopValue1 = 3;
int stopValue2 = 10;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);

Console.WriteLine(res);

Console.ReadKey();