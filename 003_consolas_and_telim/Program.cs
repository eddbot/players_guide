Console.WriteLine("Bread is ready");
Console.WriteLine("Who is the bread for?");

var name = Console.ReadLine();

if (string.IsNullOrEmpty(name))
{
    name = "anon";
}

Console.WriteLine($"Noted, {name} got bread");