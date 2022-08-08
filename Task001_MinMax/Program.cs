Console.WriteLine("Введите число a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b ");
int b = Convert.ToInt32(Console.ReadLine());
int min = a;
int max = b;

if(a>b){max = a; min = b;}

Console.WriteLine("Максимальное число найдено, max = " + max);
Console.WriteLine("Минимальное число найдено, min = " + min);
