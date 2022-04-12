int[] array = {1, 23, 54, 65, 45, 545, 546, 36 };

int n = array.Length;
int find = 545;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }

    // index = index +1;
    index++;
}
