Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Akkermans(n, m);

int Akkermans (int x, int y)
{
if (x == 0) return y + 1;
if (x != 0 && y == 0)  return Akkermans(y - 1, 1);
if (x > 0 && y > 0) return Akkermans(x - 1, Akkermans(x, y - 1));
return Akkermans(x,y);
}
