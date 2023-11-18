int id = 1;
ShowId(ref id);
Console.WriteLine($"Id is {id}");

static void ShowId(ref readonly int id)
{
    Console.WriteLine($"Id is {id}");
}