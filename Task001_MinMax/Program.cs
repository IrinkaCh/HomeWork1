Console.WriteLine("Введите число a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b ");
int b = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 0;

if(a>b)
{
max = a;
min = b;
}
else
{
max = b;
min = a;
}
Console.Write("Максимальное число найдено, max = ");
Console.WriteLine(max);
Console.Write("Минимальное число найдено, min = ");
Console.WriteLine(min);