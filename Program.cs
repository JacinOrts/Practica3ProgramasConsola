// See https://aka.ms/new-console-template for more information
string txt1 = Console.ReadLine();
int num1 = Int32.Parse(txt1);
string txt2 = Console.ReadLine();
int num2 = Int32.Parse(txt2);
Console.WriteLine("PRIMER NÚMERO: " + num1);
Console.WriteLine("SEGUNDO NÚMERO: " + num2);
Console.WriteLine("LA SUMA ES: " + (num1+num2));
Console.WriteLine("LA RESTA ES: " + num1 + " - " + num2 + " = " + (num1-num2));
Console.WriteLine("LA MULTIPLICACIÓN ES: " + (num1*num2));
Console.WriteLine("LA DIVISIÓN ES: " + (num1/num2));
Console.WriteLine("EL RESIDUO ES: " + num1%num2);
