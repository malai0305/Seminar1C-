// Выяснить являются ли три числа сторонами треугольника.
bool CheckTriagle (int a,int b, int c)=> a+b>c&&b+c>a&&a+c>a;
Console.WriteLine("Введите первое число :");
int a = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе число :");
int b = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите третье число :");
int c = int.Parse(Console.ReadLine()??"0");
bool check=CheckTriagle(a,b,c);
Console.WriteLine(check?"Три числа являются сторонами треугольника":"Три числа не являются сторонами треугольника ");