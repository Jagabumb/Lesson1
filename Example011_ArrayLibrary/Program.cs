void FillArray(int[] collection)
{
  int Length = collection.Length;
  int index = 0;
  while (index < Length)
  {
    collection[index] = new Random().Next(1, 10);
    //index == index + 1;
    index++;
  }
}

void PrintArray(int[] col) //void - значит ничего не возращает
{
  int count = col.Length;
  int position = 0;
  while (position < count)
  {
    Console.WriteLine(col[position]);
    position++;
  }
}

int IndexOff(int[] collection, int find)
{
  int count = collection.Length;
  int index = 0;
  int position = -1;

  while (index < count)
  {
    if (collection[index] == find)
    {
      position = index;
      break;
    }
    index++;
  }
  return position;
}

int[] array = new int[10]; //new int - создай новый массив в котором будет 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array, 4);
Console.WriteLine(pos);

