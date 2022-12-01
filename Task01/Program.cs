// Написать программу, которая из имеющегося массива строк, 
//формирует массив из строк длинна которых меньше, либо равна 3. 
// Первоначальный массив можно ввести с клавиатуры или задать на старте задания алгоритма.
// при решении не рекомендуется использовать коллекции.

string[] FullArrFromText (string[] Text, int n, int a)
{
    string [] result = new string[n];
    int k = 0;
    for (int i = 0; i < Text.Length; i++)
    {
        if (Text[i].Length <= a)
        {
            result[k] = Text[i];
            k+=1;
        }
    }
    return result;
}
void PrintTextArr(string[] text)
{
    Console.Write("[");
    for (int i = 0; i < text.Length; i++)
    {
        if(i < text.Length - 1) Console.Write($"{text[i]},");
        else Console.Write($"{text[i]}");
    }
    Console.WriteLine("]");
}
int CountElemInArr(string[] text, int a)
{
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= a) count +=1;
    }
    return count;
}

string[] startText = {"Написать", "программу,", "которая", "из", "массива", "ст", "формирует", "мас", "из", "3."};
Console.WriteLine("Введите максимальное количество символов, которые должны содержаться в строке:");
int num = Convert.ToInt32(Console.ReadLine());
int c = CountElemInArr(startText, num);
string[] newStringArr = FullArrFromText(startText, c, num);
PrintTextArr(newStringArr);

