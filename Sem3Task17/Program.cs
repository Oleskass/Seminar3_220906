// ===============================================================
// #17 Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти 
// плоскости, в которой находится эта точка.
// Например: x=34; y=-30 -> 4, x=2; y=4-> 1, x=-34; y=-30 -> 3
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

int QuarterTest(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x > 0 && y < 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x < 0 && y > 0)
        return 4;

        return -1; //дефолтное значение
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x = ReadData("Введите координату X:");
int y = ReadData("Введите координату Y:");

int res = QuarterTest(x, y);

PrintResult("Точка находится в четверти №:" + res);