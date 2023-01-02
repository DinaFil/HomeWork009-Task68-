Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkermans(n, m));

int Akkermans (int x, int y)
{
int result = 0;
if (x == 0) result = y + 1;
if (x != 0 && y == 0)  result = Akkermans(y - 1, 1);
if (x > 0 && y > 0) result = Akkermans(x - 1, Akkermans(x, y - 1));
return result;
}
