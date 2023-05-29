// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(" 1 ile 5 arasında bir değer giriniz");

int girilen = Convert.ToInt32(Console.ReadLine());
double can = Math.PI;  //PI sayısı 3 e tanimlanmıs.
int kusursuz = Convert.ToInt32(can);
Console.WriteLine(kusursuz*girilen);
Console.ReadLine();