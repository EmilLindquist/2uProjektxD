int x = 4;
int y = 5;
int z = x + y;
int d = x + y - z * x / z % y;

string str = "Result of d is = ";

Console.WriteLine("x = " + x + " and y = " + y + " and x + y = " + z);
Console.WriteLine(str + d);
