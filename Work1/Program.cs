using WSUniversalLib;

Console.Write("Введите колличество: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Введите ширину: ");
int widht = int.Parse(Console.ReadLine());
Console.Write("Введите длину: ");
int height = int.Parse(Console.ReadLine());
Console.Write("Введите номер продукции: ");
int ProdType = int.Parse(Console.ReadLine());
Console.Write("Введите тип материала: ");
int MaterialType = int.Parse(Console.ReadLine());


Calculation c = new Calculation();
int a = Calculation.GetQuantityForProduct(count, widht, height, ProdType, MaterialType);
Console.Write("\nРезультат: " + a + "\n");

