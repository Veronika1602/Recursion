// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

using System;
public class Transformation
{
    public void display(int[] data, int size)
    {
        for (var i = 0; i < size; ++i)
        {
            Console.Write(" " + data[i].ToString());
        }
        Console.Write("\n");
    }
    public void reverseArray(int[] data, int front, int tail)
    {
        if (front < tail)
        {
            var auxiliary = data[front];
            data[front] = data[tail];
            data[tail] = auxiliary;
            this.reverseArray(data, front + 1, tail - 1);
        }
    }
    public static void Main(String[] args)
    {
        var task = new Transformation();
        int[] data = {
 1 , 2 , 7 , 3 , 4 , 5 , 8 , 9
 };
        var size = data.Length;
        Console.WriteLine(" Исходный массив ");
        task.display(data, size);
        task.reverseArray(data, 0, size - 1);
        Console.WriteLine(" Массив после реверса ");
        task.display(data, size);
    }
}
