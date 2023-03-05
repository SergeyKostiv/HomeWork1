         // Task 1. Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
/*
int CutNumber(int num)
{
    int hundreds = num / 100;
    int one = num % 10;
    int two = num % 100;
    int result = two / 10;

    return result;
}
Console.Write("Input a threeDigit number ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
int newNumber = CutNumber(threeDigitNumber);
Console.WriteLine(newNumber);
*/

// Task 2. Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
/*
int ThirdDigit(int number)
{
    int result = -1;
    if (number >= 100)
    {
    while (number > 999)
    {
    number = number / 10;
    }
    result = number % 10;
    }
    return result; 
}

Console.Write("Input three-digit number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (ThirdDigit(number1) == -1)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine($"Third digit is {ThirdDigit(number1)}");
*/

//Task 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
/*
void IsDayWeek(int number) 
{
  if (number == 6 || number == 7) 
  {
  Console.WriteLine("(этот день выходной) -> Yes");
  }
  else 
  if (number > 1 || number < 7)
  {
    Console.WriteLine("(этот день не выходной) -> No");
  }
  
}

Console.Write("Input a day number ");
int numb = Convert.ToInt32(Console.ReadLine());

IsDayWeek(numb);
*/

