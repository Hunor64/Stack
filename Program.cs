Stack<int> stack = new();
Random rand = new();
for (int i = 0; i < 25; i++)
{
    stack.Push(rand.Next(1, 100));
}

List<int> sortedList = stack.ToList();
sortedList.Sort();
sortedList.Reverse();
stack = new Stack<int>(sortedList);

foreach (var elem in stack)
{
    Console.WriteLine(elem);
}