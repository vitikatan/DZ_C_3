Console.Clear ();
Console.WriteLine("Введите координаты первой точки:");

Console.WriteLine("Координаты x1:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Координаты y1:");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Координаты z1:");
double z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");

Console.WriteLine("Координаты x2:");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Координаты y2:");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Координаты z2:");
double z2 = double.Parse(Console.ReadLine());

double stepen = 2;
double S = Math.Sqrt(Math.Pow((x1-x2),stepen) + Math.Pow((y1-y2),stepen) + Math.Pow((z1-z2),stepen));
Console.WriteLine($"Расстояние между этими точками равно:{S}");
