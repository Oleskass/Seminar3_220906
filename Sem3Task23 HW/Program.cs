// ===============================================================
// #23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.1
// 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом
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

//создаёт строку чисел, возведёных в pow степень
string LineNumbers(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";
        ++i;
    }
    outLine = outLine + Math.Pow(numberN, pow);
    return outLine;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Сама программа:
//собираем данные
int num = ReadData("Введите число: ");
//вычисляем и выводим результат
PrintResult(LineNumbers(num, 1));
PrintResult(LineNumbers(num, 3));