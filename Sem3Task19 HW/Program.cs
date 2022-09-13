// ===============================================================
// #19 Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет; 23432 -> да; 12821 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов или
// написать решение для палиндрома любой длины (1:38 в лекции)
// ===============================================================

//принимаем данные от пользователя
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//ВАРИАНТ 1
//вычисляем, палиндром это или нет
string PalindromTest(int numPal)
{
    if (numPal > 9999 && numPal < 100000)
    {
        if (((numPal / 10000) == (numPal % 10)) && ((numPal / 1000 % 10) == (numPal / 10 % 10)))
        {
            return "Это палиндром";
        }
        else
        {
            return "Это не палиндром";
        }
    }
    else
    {
        return "Это не пятизначное число, попробуйте ещё раз.";
    }
}

//вывод результата
void PrintData(string line)
{
    Console.WriteLine(line);
}

//сама программа, обращаемся к методам
int num = ReadData("Введите пятизначное число: ");
PrintData(PalindromTest(num));

//ВАРИАНТ метода с bool
//вычисляем, палиндром это или нет
// bool PalindromTest(int numPal)
// {
//         if (((numPal / 10000) == (numPal % 10)) && ((numPal / 1000 % 10) == (numPal / 10 % 10)))
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
// }

// //сама программа, обращаемся к методам
// int num = ReadData("Введите пятизначное число: ");
// bool res = PalindromTest(num);
// PrintData("Тест на палиндром: " + res);


// //проверка вычисления цифр, для себя
// //12321
// int numPal = int.Parse(Console.ReadLine() ?? "");
// Console.WriteLine((numPal) + " " + (numPal / 10000) + " " + (numPal % 10) + " " + (numPal / 1000 % 10) + " " + (numPal / 10 % 10));