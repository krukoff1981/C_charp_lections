string Method4(int count, string text)
{
    string result = String.Empty;//или ="":
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(text: "Why? ", count: 5);
Console.WriteLine(res);
