﻿// temp <= 0 its freezing cold
// temp > 0 AND temp <= 10 - Cold
// temp >= 10 AND temp < 15- chilly
// temp >= 15 AND temp < 20 - warm
// temp >= 20 AND temp < 30 - hot
// temp >= 30 - boiling hot

Console.WriteLine("enter your temperature: ");
int temp = Int32.Parse(Console.ReadLine());

if (temp >= 30)
{
    Console.WriteLine("boiling hot");
}
else if (temp < 30 && temp >= 20)
{
    Console.WriteLine("Hot");
}
else if (temp < 20 && temp >= 15)
{
    Console.WriteLine("warm");
}
else if (temp < 15 && temp >= 10)
{
    Console.WriteLine("chilly");
}
else if(temp < 10 && temp > 0)
{
    Console.WriteLine("cold");
}
else
{
    Console.WriteLine("freezing cold");
}