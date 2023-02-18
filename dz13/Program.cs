//Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//645->5
//78-> третьей цифры нет
//32679->6
Console.WriteLine("Введите число: ");
string SecondNumber = Console.ReadLine();
int chars = Convert.ToInt32(SecondNumber);
if(chars>99)
{
    Console.WriteLine(SecondNumber.Substring(2,1));
}
else
{
    Console.WriteLine("Третьей цифры нет");
}