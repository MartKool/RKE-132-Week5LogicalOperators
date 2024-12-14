// Math >= 90 OR Chemistry >= 90

// math && chemistry || math && bilogy || bilogy && chemistry

int math, biology, chemistry;

Console.WriteLine("Enter your math result");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result");
chemistry = Int32.Parse(Console.ReadLine());

if((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) ||(biology >= 90 && chemistry >= 90))
{
    Console.WriteLine("congratulation! you have been accepted!");
}
else
{
    Console.WriteLine("you cannot be accepted");
}