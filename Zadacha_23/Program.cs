Console.Clear ();
Console.WriteLine("Введите число:");
double number = double.Parse(Console.ReadLine());
double max = 1;
double i = 1;
double stepen =3;

while (i <= number)
{
    max = Math.Pow(i, stepen);
    i = i + 1;
    Console.WriteLine(max);
}
