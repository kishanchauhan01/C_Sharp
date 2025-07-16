using System;

public class Node
{
    public int data;
    public Node next;

    Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

public class CircularLL
{
    private Node tail;
    private int size;

    public CircularLL()
}