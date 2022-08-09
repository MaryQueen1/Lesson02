int[] array = {1, 23, 54, 4, 654, 76, 2, 4};// определим новый массив

int n = array.Length; // (кол-во эл. массива)
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}