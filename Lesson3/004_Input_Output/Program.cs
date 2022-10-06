string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;//или ="":
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(text:"Why? ", count:5);
Console.WriteLine(res);