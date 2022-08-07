Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());

//int max = a;
//if(a>b){max = a;}
//else{max = b;}
//if(b>c){max = b;}
//else{max = c;}
//if(c>a){max = c;}
//else{max = a;}

int max = a;
if(a<b){max = b;}
if(max<c){max = c;}

Console.Write("Максимальное число найдено, max = ");
Console.WriteLine(max);
