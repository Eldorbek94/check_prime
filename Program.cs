
Console.WriteLine("CHeck prime number!");
int number = Convert.ToInt32(Console.ReadLine());
if(number==1) Console.WriteLine("TUB SON EMAS");
if(number==2) Console.WriteLine("TUB SON");
if(number==3) Console.WriteLine("TUB SON");
int res = -1,res1=-1;
if(number>3) res = (number+1)%6;
if(res>0) res1 = (number-1)%6;
if(res1>0) Console.WriteLine($"TUB SON EMAS");
if(res1==0)Console.WriteLine($"TUB SON");
if (res==0) Console.WriteLine($"TUB SON");
if(number<0) Console.WriteLine("Manfiy son kiritdiz");