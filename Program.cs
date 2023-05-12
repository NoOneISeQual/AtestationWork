Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
string[] StringArray = new string [n];
string[] StringArray2 = new string [n];

int max = 3;
int count = 0;

for (int i = 0; i < StringArray.Length; i++)
{
    Console.WriteLine($"Введите {i+1} элемент массива:");
    StringArray[i] = Convert.ToString(Console.ReadLine()!);
    {
        if (StringArray[i].Length <= max)
        {
            StringArray2[count] = StringArray[i];
            count++;
        }
    }
}

Console.WriteLine($"Элементы меньше или равны 3: {string.Join(", ", StringArray2)}");

// 2 ВАРИАНТ:

void StringArrays (string[] Array1, string[] Array2)
{
    for(int i = 0; i < Array1.Length; i++)
    {
        if (Array1[i].Length <= 3)
        {
            Array2[i] = Array1[i];
        }
    }
}

void ArrayString (string[] Array1)
{
    for (int i = 0; i < Array1.Length; i++)
    {
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    Array1[i] = Convert.ToString(Console.ReadLine()!);
    }
}