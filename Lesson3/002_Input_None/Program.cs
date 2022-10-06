void Method2(string arg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(arg);
        i++;
    }
}
Method2(count: 2,arg: "Привет");//Method2("Привет",2); - можно и такю если аргументы именуются, то в любом порядке,
                                //если нет, то только в порядке, прописанном в методе
