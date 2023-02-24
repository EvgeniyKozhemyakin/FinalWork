// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"'{array[i]}', ");
        else Console.Write($"'{array[i]}'");
    }
    Console.Write("]");
}
string[] ArrLessThreeChar(string[] arrInitial)
{
    string[] arrFinal = new string[arrInitial.Length];
    int count = 0;
    for (int i = 0; i < arrInitial.Length; i++)
    {
        if (arrInitial[i].Length <= 3)
        {
            arrFinal[count] = arrInitial[i];
            count++;
        }
    }
    Array.Resize(ref arrFinal, count);
    return arrFinal;
}

Console.Write("Введите элементы массива через пробел: ");
string str = Console.ReadLine();
string[] strArray = str.Split(' ');

string[] arrayLessThree = ArrLessThreeChar(strArray);

PrintArray(strArray);
Console.Write(" -> ");
PrintArray(arrayLessThree);





