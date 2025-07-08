using System;

public class Node
{
    public int data;
    public Node next, prev;
    //public static int size;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
        this.prev = null;
    }

}

public class LinkedList
{
    private Node head;
    private Node tail;
    private int size;

    public LinkedList()
    {
        this.head = null;
        this.tail = null;
        this.size = 0;
    }

    public int getSize()
    {
        return this.size;
    }

    public void print()
    {
        if (this.head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        Node temp = this.head; //temp is now a reference to the same object in memory that head is pointing to.
        while (temp != null)
        {
            Console.Write(temp.data + "-> ");
            temp = temp.next;
        }
        Console.WriteLine("null");
    }

    public void insertAtHead(int d)
    {
        if (this.size == 0)
        {
            Node temp = new Node(d);
            this.head = temp;
            this.tail = temp;
            this.size++;
        }
        else
        {
            Node temp = new Node(d);
            temp.next = this.head;
            this.head.prev = temp;
            this.head = temp;
            this.size++;

        }
    }

    public void insertAtTail(int d)
    {
        if (size == 0)
        {
            Node temp = new Node(d);
            this.head = temp;
            this.tail = temp;
            this.size++;
        }
        else
        {
            Node temp = new Node(d);
            this.tail.next = temp;
            temp.prev = this.tail;
            this.tail = temp;
            this.size++;
        }
    }

    public void insertAtPosition(int position, int d)
    {
        if (position == 1)
        {
            insertAtHead(d);
            return;
        }

        Node temp = this.head;
        int cnt = 1;
        while (cnt < position - 1)
        {
            temp = temp.next;
            cnt++;
        }

        Node nodeToInsert = new Node(d);
        nodeToInsert.next = temp.next;
        temp.next.prev = nodeToInsert;
        nodeToInsert.prev = temp;
        temp.next = nodeToInsert;
    }

    public void deleteNode(int position)
    {
        if (position == 1)
        {
            Node temp = this.head;
            temp.next.prev = null;
            this.head = temp.next;
            temp.next = null;
            this.size--;
        }
        else
        {
            Node curr = this.head;
            Node temp = null;
            int cnt = 1;

            while (cnt < position)
            {
                temp = curr;
                curr = curr.next;
                cnt++;
            }

            curr.prev = null;
            temp.next = curr.next;
            if (temp.next == null)
            {
                this.tail = temp;
            }
            else
            {
                curr.next.prev = temp;
            }

            curr.next = null;

        }
    }
}


public class ProgramLL
{
    public static void Main(string[] args)
    {
        LinkedList l1 = new LinkedList();
        l1.insertAtHead(1);
        l1.insertAtHead(2);
        l1.insertAtHead(3);
        l1.insertAtTail(4);
        l1.insertAtTail(5);
        l1.print();
        l1.insertAtPosition(3, 100);
        l1.print();

        l1.deleteNode(2);
        l1.print();
        //Console.WriteLine("Size of List is: " + l1.getSize());
    }
}   // ← ✅ This final brace closes the class
