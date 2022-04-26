// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Console.WriteLine("Введите число: ");
//int namber = int.Parse(Console.ReadLine());

//if (namber >= 1000 & namber < 10000)
//{
//    namber = namber / 10;
//    namber = namber % 10;
//    Console.WriteLine($"третьей цифра в данном числе = {namber}");
//} else
//    if (namber > 100 & namber < 1000)
//    {
//        namber = namber % 10;
//        Console.WriteLine($"третьей цифра в данном числе = {namber}");
 //   }
//else Console.WriteLine("третьей цифры нет");


Console.WriteLine("Введите число: ");
int namber = int.Parse(Console.ReadLine());

while(namber >= 1000)
{
    namber = namber / 10;
}

Console.WriteLine("третье число:" + namber % 10);

if(namber < 100)

{
    Console.WriteLine("третьего числа нет");
}