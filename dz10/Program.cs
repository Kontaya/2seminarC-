//Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
//456->5
//782->8
//918->1
Console.WriteLine("Введите число: ");
string SecondNumber = Console.ReadLine();
int chars = Convert.ToInt32(SecondNumber);
if(chars>99 && chars<1000)
{
    Console.WriteLine(SecondNumber.Substring(1,1));
}
else
{
    Console.WriteLine("Вы ввели неверное число!");
}