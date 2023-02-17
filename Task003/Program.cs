// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int x = Convert.ToInt32(Console.ReadLine());
if (x < 6)
{
    Console.WriteLine("Будний день");
}
else
{
    Console.WriteLine("Выходной)");
}