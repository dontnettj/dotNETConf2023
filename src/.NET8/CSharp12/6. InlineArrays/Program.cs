using InlineArrays;

var array = new InlineArrayExample();
for (int i = 0; i < 10; i++)
{
    array[i] = i;
}

foreach (var example in array)
{
    Console.WriteLine(example);
}