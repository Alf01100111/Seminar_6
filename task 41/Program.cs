
System.Console.WriteLine("Введите кол. вводимых чисел");
int m = Convert.ToInt32(Console.ReadLine());

int count = 0;
while (m > 0)
{
    System.Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        count++;
    }
    m--;
}

System.Console.WriteLine($"Вы ввели {count} чисел больше ноля ");