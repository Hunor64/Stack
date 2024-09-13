Stack<int> mainStack = new();
Random rand = new();
for (int i = 0; i < 25; i++)
{
    mainStack.Push(rand.Next(1, 100));
}

foreach (var elem in mainStack.Sort())
{
    Console.WriteLine(elem);
}

public static class StackExtensions
{
    public static Stack<int> Sort(this Stack<int> stack)
    {
        List<int> sortedList = stack.ToList();
        sortedList.Sort();
        sortedList.Reverse();
        return new Stack<int>(sortedList);
    }
}