/*int[] input = {1,6,4,1,4,2,7,4,6};
 
        var set = new HashSet<int>();
        var upprepas = input.Where(i => !set.Add(i)).Distinct();
 
        Console.Write("Uppgift 3: ");
        Console.WriteLine(String.Join(", ", upprepas)); */

Stack<int> stack = new Stack<int>();

string input = "*+12-34";

for (int i = input.Length - 1; i >= 0; i--)
{
    char c = input[i];
    if(c == '-'){
    int result = stack.Pop() - stack.Pop();
    stack.Push(result);
    }
    else if(c == '*'){
        int result = stack.Pop() * stack.Pop();
        stack.Push(result);
    }
    else if(c == '+'){
        int result = stack.Pop() + stack.Pop();
        stack.Push(result);
    }
    else{
        stack.Push(int.Parse(c.ToString()));
    }
}

Console.WriteLine(stack.Pop());