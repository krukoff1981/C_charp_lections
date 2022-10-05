//Сравнение пяти отдельных весов 
int a = 2;
int b = 5;
int c = 3;
int d = 9;
int e = 1;
int max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.Write("max = ");
Console.WriteLine(max);