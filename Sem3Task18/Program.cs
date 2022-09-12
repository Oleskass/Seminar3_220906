// ===============================================================
// #18 Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)
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

string QuarterBorder(int quarterNum)
{
    if (quarterNum == 1)
        return "x > 0 y > 0";
    if (quarterNum == 2)
        return "x > 0 y < 0";
    if (quarterNum == 3)
        return "x < 0 y < 0";
    if (quarterNum == 4)
        return "x < 0 y > 0";

        return "-"; //дефолтное значение
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int quarterNum = ReadData("Введите номер четверти: ");

string res = QuarterBorder(quarterNum);

PrintResult("Возможные координаты точек в заданной четверти: " + res);