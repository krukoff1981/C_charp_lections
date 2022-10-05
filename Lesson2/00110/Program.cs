void FillArray(int[] collection) //метод вставка чисел в массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);

        index++;
    }
}

void PrintArray(int[] coll) // метод вывод массива на печать
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
    Console.WriteLine(coll[position]);
    position++;
    }
}

int IndexOf(int[]collect, int find) // метод поиск конкретного значения
{
    int count = collect.Length;
    int index = 0;
    int position = -1;
    while(index<count)
    {
        if(collect[index]==find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[20];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 9);
Console.WriteLine(pos);
