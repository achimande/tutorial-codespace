using System.Runtime.InteropServices;

WorkWithIntegers();
OrderPrecedence();
void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);

    c = a - b;
    Console.WriteLine(c);

    c = a * b;
    Console.WriteLine(c);

    c = a / b;
    Console.WriteLine(c);
}

void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}

int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

double aa = 5;
double bb = 4;
double cc = 2;
double dd = (aa + bb) / cc;
Console.WriteLine(dd);

double max_d = double.MaxValue;
double min_d = double.MinValue;
Console.WriteLine($"The range of double is {min_d} to {max_d}");

double third = 1.0 / 3.0;
Console.WriteLine(third);

decimal aaa = decimal.MinValue;
decimal bbb = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {aaa} to {bbb}");

double aaaa = 1.0;
double bbbb = 3.0;
Console.WriteLine(aaaa / bbbb);

decimal cccc = 1.0M;
decimal dddd = 3.0M;
Console.WriteLine(cccc / dddd);

double r = 2.5;
double area = Math.Round(Math.PI * r * r, 2);//四舍五入
double area1 = Math.Truncate(Math.PI * r * r * 100) / 100;//截断
double area2 = Math.Ceiling(Math.PI * r * r * 100) / 100;//向上取整
double area3 = Math.Floor(Math.PI * r * r * 100) / 100;//向下取整
string str = (Math.PI * r * r).ToString("0.00");//格式化字符串

Console.WriteLine($"Area of a circle with radius {r} is {area} ");
Console.WriteLine($"Truncated area of a circle with radius {r} is {area1}");
Console.WriteLine($"Rounded up area of a circle with radius {r} is {area2}");
Console.WriteLine($"Rounded down area of a circle with radius {r} is {area3}");
Console.WriteLine($"Formatted area of a circle with radius {r} is {str}");

decimal result;
result = Math.Round(3.45m, 1, MidpointRounding.ToEven);
Console.WriteLine($"{result} = Math.Round({3.45m}, 1, MidpointRounding.ToEven)");
result = Math.Round(3.45m, 1, MidpointRounding.AwayFromZero);
Console.WriteLine($"{result} = Math.Round({3.45m}, 1, MidpointRounding.AwayFromZero)");
result = Math.Round(3.47m, 1, MidpointRounding.ToZero);
Console.WriteLine($"{result} = Math.Round({3.47m}, 1, MidpointRounding.ToZero)\n");