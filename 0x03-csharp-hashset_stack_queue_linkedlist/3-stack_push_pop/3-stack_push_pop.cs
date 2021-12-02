using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int number_of_elements = aStack.Count;
        string top_element;
        string contains_element = "False";
        top_element = number_of_elements == 0 ? "Stack is empty" : "Top item: " + aStack.Peek();

        if (aStack.Contains(search))
        {
            while(aStack.Peek() != search)
            {
                aStack.Pop();
            }
            aStack.Pop();
            contains_element = "True";
        }

        aStack.Push(newItem);

        Console.WriteLine("Number of items: {0}", number_of_elements);
        Console.WriteLine("{0}", top_element);
        Console.WriteLine("Stack contains {0}: {1}", search, contains_element);
        return aStack;
    }
}