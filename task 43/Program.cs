
double[] Linevar(string line)
{
    double[] resultlinevar = new double[2];
    System.Console.WriteLine($"Введите переменную K для {line}");
    resultlinevar[0] = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine($"Введите переменную B для {line}");
    resultlinevar[1] = Convert.ToDouble(Console.ReadLine());
    return resultlinevar;
}


double[] line1 = Linevar("первой прямой");
double[] line2 = Linevar("второй прямой");

double x = 0;     // k - [0] b - [1]
double y = 0;

if (line1[0] == line2[0] && line1[1] != line2[1])
{
    System.Console.WriteLine("Прямые параллельны");
}
else if (line1[0] == line2[0] && line1[1] == line2[1])
{
    System.Console.WriteLine("Прямые совпадают");
}
else
{
    x = (line2[1] - line1[1]) / (line1[0] - line2[0]);
    y = line1[0] * x + line1[1];
    System.Console.WriteLine($"Точка пересечения прямых x={x} y={y}" );
}
