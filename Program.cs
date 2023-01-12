string input = "[()]{}{[()()]()}";
Stack<string> stack = new Stack<string>();

stack.Push("[");
stack.Push("(");
stack.Push(")");
stack.Push("]");
stack.Push("{");
stack.Push("}");
stack.Push("{");
stack.Push("[");
stack.Push("(");
stack.Push(")");
stack.Push("(");
stack.Push(")");
stack.Push("]");
stack.Push("(");
stack.Push(")");
stack.Push("}");
