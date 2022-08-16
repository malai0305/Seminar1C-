//вывести число в двоичную систему счисления
Console.Clear();
int ToBinar(int value ){
    int binar = 0;
    int i = 0;
    while(value>=1){
        binar=binar+value%2*(int)Math.Pow(10,i);
        Console.WriteLine(binar);
        value=value/2;
        i++;}
        return binar;
    }
 Console.WriteLine("Введите число:");    
int value = int.Parse(Console.ReadLine());
// string BinariCode = Convert.Tostring(value,2);
Console.WriteLine(ToBinar(value));