/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/


int GetArrayLength()
// Метод запрашивает длину массива
{
    Console.WriteLine("Введите длину массива ");
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

string[] InitArray(int lenArr)
// Метод заполняет массив определнной длины
{
    string[] array = new string[lenArr];
    Console.WriteLine($"Заполните массив строк из {lenArr} элементов:");
    for (int i = 0; i < lenArr; i++)
    {
        array[i] = Console.ReadLine() ?? "";
    }
    return array;
}

string[] CalcNewArray(string[] array)
// Метод выделяет массив строк, длина каждого элемента которого не больше 3 символов
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) ++count;
    }
    if (count == 0) return new string[0];
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

int lenArr = GetArrayLength();
string[] array = InitArray(lenArr);
Console.WriteLine("[{0}]", string.Join(", ",CalcNewArray(array)));