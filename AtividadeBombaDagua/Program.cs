Console.WriteLine("Qual seria o estado da bomba A? (1:ligado 0:desligado)");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Qual seria o estado da bomba B? (1:ligado 0:desligado)");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Qual seria o estado da bomba C? (1:ligado 0:desligado)");
int c = int.Parse(Console.ReadLine());

if(a == 0 && b == 0 && c == 0)
{
    Console.WriteLine("Ligue a torneira");
}
else if(a == 0 && b == 0 && c == 1)
{
    Console.WriteLine("Ligue a torneira");
}
else if(a == 0 && b == 1 && c == 0)
{
    Console.WriteLine("Há algum erro nos sensores.");
}
else if(a == 0 && b == 1 && c == 1)
{
    Console.WriteLine("Há algum erro nos sensores");
}
else if(a == 1 && b == 0 && c == 0)
{
    Console.WriteLine("Ligue a torneira e ligue a bomba");
}
else if(a == 1 && b == 0 && c == 1)
{
    Console.WriteLine("Ligue a torneira");
}
else if(a == 1 && b == 1 && c == 0)
{
    Console.WriteLine("Ligue a bomba");
}
else if(a == 1 && b == 1 && c == 1)
{
    Console.WriteLine("Tudo funcionando corretamente");
}