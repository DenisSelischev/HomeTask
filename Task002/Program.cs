// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
long number = Convert.ToInt32(Console.ReadLine());

if(number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(number.ToString()[2]);
}


