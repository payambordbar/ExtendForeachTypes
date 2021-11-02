using ExtendForeachTypes;

Console.WriteLine("---int---");
foreach (var i in 10)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------------------");
Console.WriteLine("---Tuple---");
foreach (var i in (start: 0, end: 10) /* (10, 0) */)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------------------");
Console.WriteLine("---Tuple with step---");

foreach (var i in (start: 0, end: 10, step: 2) /* (10, 0, 2) */)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------------------");
Console.WriteLine("---Range---");
foreach (var i in 1..10 /* 10..1 */)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------------------");
Console.WriteLine("---char---");
foreach (var i in ('a', 'h') /* ('h', 'a') */)
{
    Console.WriteLine(i);
}

Console.ReadKey();
