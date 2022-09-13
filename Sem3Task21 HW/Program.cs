﻿// ===============================================================
// #21 Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек (когда пользователь вводит одну 
// строчку, а мы разбираем её на значения. Line.Substring (подстрока 
// к стринговой переменной) ИЛИ Line.Split(",") = string[] в массив. 
// Расположение символа Line.indexof(",") ИЛИ Lastindexof(",") 
// это последний символ)
// ===============================================================

//чтение данных пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

//находим расстояние между двумя точками 3D
double CalculateData(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return res;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

//собираем данные
int x1 = ReadData("Введите координату x1: ");
int y1 = ReadData("Введите координату y1: ");
int z1 = ReadData("Введите координату z1: ");
int x2 = ReadData("Введите координату x2: ");
int y2 = ReadData("Введите координату y2: ");
int z2 = ReadData("Введите координату z2: ");

//высчитываем расстояние
double res = CalculateData(x1, y1, z1, x2, y2, z2);

//выводим результат, округлённый до сотых
PrintResult("Расстояние между точками: " + Math.Round(res, 2));