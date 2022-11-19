
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

/*
int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}
 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int InCenter(int a)
{
   
    int result = ((a / 10) % 10);
    return result;
    {
        
    }
}
*/



//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
int number = ReadInt("Введите число: ");
int count = number.ToString().Length;

Console.Write(MakeArray(number, count));



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int MakeArray(int a, int b)
{
int input = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет ");
    }

    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        input = (a / c) % 10;
       
    }
return input;
}
*/


//Задача 15: 
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

/*
int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Под числом " + a + " - Выходной день");
        }
        else
        {
            Console.Write("Под числом " + a + " - Рабочий день");
        }
    }
    else
    {
        Console.Write("введенное число не в пределах от 1 до 7, ошибка неверные данные.");
    }
    return "";
}
*/