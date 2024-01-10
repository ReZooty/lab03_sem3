MyClass m = new();

Console.WriteLine(m[0]);

class MyClass
{
    int[] ints = { 1, 2, 3, 4, 5, 6 };
    public int this[int index]
    {
        get { return ints[index]; }
    }

}