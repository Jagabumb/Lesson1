int[] array = { 31, 22, 3, 411, 53, 64, 27, 811 };

int n = array.Length;
int find = 811;

int index = 0;

while (index < n)
{
  if (array[index] == find)
  {
    Console.WriteLine(index);
    break;
  }
  index++;
}