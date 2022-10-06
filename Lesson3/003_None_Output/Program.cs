int Method3()
{
    return DateTime.Now.Day;
}
int Method3a()
{
    return DateTime.Now.Month;
}
int Method3b()
{
    return DateTime.Now.Year;
}
int day = Method3();
int month = Method3a();
int year = Method3b();
Console.WriteLine($"{day}/{month}/{year}");

//Console.WriteLine($"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}");