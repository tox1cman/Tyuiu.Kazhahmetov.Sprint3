using Tyuiu.Kazhahmetov.Spritn3.Task0.V15.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Кажахметов А. Е. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #15                                                             *");
Console.WriteLine("* Выполнил: Кажахметов Амир Ерболович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Значение:");
double value = Convert.ToDouble(Console.ReadLine());

int startValue = 1;
int stopValue = 10;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.GetSumSeries(value, startValue, stopValue);

Console.WriteLine(res);
Console.ReadKey();
