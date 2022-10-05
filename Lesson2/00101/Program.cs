int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int n = array.Length;
int i = 0;
int index = 0;
while (index < n)
{
   if(array[index]%2==0)
   {
        i++;
   } 
    index++;
}
Console.WriteLine(i);