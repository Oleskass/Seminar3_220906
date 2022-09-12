// ===============================================================
// #22 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// Например: 5 -> 1, 4, 9, 16, 25; 2 -> 1,4
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
PrintResult(LineNumbers(num, 2));

// ИЛИ
// //вычисляем
// string lineTop = LineNumbers(num, 1);
// string lineBottom = LineNumbers(num, 2);

// //выводим результат
// PrintResult(lineTop);
// PrintResult(lineBottom);

// ИЛИ развёрнутое решение
// //строка чисел до numberN
// string LineNumbers(int numberN)
// {
//     int i = 1;
//     string outLine = string.Empty;
//     while (i < numberN)
//     {
//         outLine = outLine + i + " ";
//         ++i;
//     }
//     outLine = outLine + numberN;
//     return outLine;
// }

// //строка квадратов чисел до numberN
// string LineSquare(int numberN)
// {
//     int i = 1;
//     string outLine = string.Empty;
//     while (i <= numberN)
//     {
//         outLine = outLine + i * i + " ";
//         ++i;
//     }
//     outLine = outLine;
//     return outLine;
// }


// //вычисляем
// string lineTop = LineNumbers(num);
// string lineBottom = LineSquare(num);

// //выводим результат
// PrintResult(lineTop);
// PrintResult(lineBottom);