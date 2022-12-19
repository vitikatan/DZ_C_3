Console.Clear ();
Console.Write("Введите пятизначное число: ");

int number = int.Parse(Console.ReadLine());

string str = number + string.Empty;

if (str[0] == str[4] && str[1] == str[3])
{
    Console.Write("Это число палиндром");
}
else 
{
    Console.Write("Это число не палиндром");
}