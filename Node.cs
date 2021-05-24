using System;

public class Node
{
    public int content { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    // print
    public void PrintNote()
    {
        Console.Write(this.content + " ");
    }
}

