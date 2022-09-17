// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();

char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

Console.WriteLine("Введите числа через пробел:");

string s = Console.ReadLine();
string[] list = s.Split(delimiterChars);

int[] ints = Array.ConvertAll(list, int.Parse);
Console.Write(String.Join(" ", ints));

int Positive(int[] array)
{
    int pos = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
        pos++;
    }
    return pos;
}

Console.WriteLine($" -> {Positive(ints)}");