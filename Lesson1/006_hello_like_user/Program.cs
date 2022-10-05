// Приветствие по конкретному имени пользователя
Console.WriteLine("Введите Ваше любимое имя");
string LikeName = Console.ReadLine();
Console.WriteLine("Введите Ваше имя");
string Name = Console.ReadLine();
if(Name.ToLower() == LikeName.ToLower())
{
    Console.Write("Hello, ");
    Console.WriteLine(Name);
}
else
{
    Console.WriteLine("Hello, man");
}