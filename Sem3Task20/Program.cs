// ===============================================================
// #20 Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// Например: A (3,6); B (2,1) -> 5,09, A (7,-5); B (1,-1) -> 7,21
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

//находим расстояние между двумя точками
double CalculateData(int x1, int y1, int x2, int y2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return res;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

//собираем данные
int x1 = ReadData("Введите координату x1: ");
int y1 = ReadData("Введите координату y1: ");
int x2 = ReadData("Введите координату x2: ");
int y2 = ReadData("Введите координату y2: ");

//высчитываем расстояние
double res = CalculateData(x1, y1, x2, y2);

//выодим результат, округлённый до сотых
PrintResult("Расстояние между точками: " + Math.Round(res, 2));