var Array = InsertArray();
int Counter = CheckNumbers (Array);

int[] InsertArray()
{

    Console.Write("Введите количество элементов массива: ");
    int ElementsCount = int.Parse(Console.ReadLine()!);
    int[] Array = new int [ElementsCount];

    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        Array[i] = int.Parse(Console.ReadLine()!);
    }

    return Array;
}
int CheckNumbers (int [] Array) {

    int Counter = 0;

     for (int i = 0; i < Array.Length; i++)
     {
        if (Array [i] > 0)
        Counter ++;
     }
     Console.WriteLine ("Количество чисел больше 0: " + Counter);
     return Counter;
}