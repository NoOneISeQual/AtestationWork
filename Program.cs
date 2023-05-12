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